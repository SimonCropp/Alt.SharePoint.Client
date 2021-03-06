﻿using System.Collections.Generic;
using System.Diagnostics;
using Mono.Cecil;
using Mono.Cecil.Cil;

public class EmptyConstructor
{
    public static void Execute(ModuleDefinition  moduleDefinition)
    {
        Dictionary<TypeDefinition, MethodReference?> processed = new();
        Dictionary<TypeReference, MethodReference> external = new();
        foreach (var type in moduleDefinition.GetTypes())
        {
            if (!type.IsClass)
            {
                continue;
            }
            if (type.IsValueType)
            {
                continue;
            }
            if (type.IsDelegate())
            {
                continue;
            }
            if (type.IsStatic())
            {
                continue;
            }

            var baseType = type.BaseType;
            if (baseType == null)
            {
                continue;
            }

            var typeEmptyConstructor = type.GetEmptyConstructor();
            if (typeEmptyConstructor != null)
            {
                MakeConstructorVisible(typeEmptyConstructor);

                processed.Add(type, typeEmptyConstructor);
                continue;
            }

            MethodReference? baseEmptyConstructor;
            if (baseType is TypeDefinition baseTypeDefinition)
            {
                baseEmptyConstructor = processed[baseTypeDefinition];
            }
            else
            {
                if (!external.TryGetValue(baseType, out baseEmptyConstructor))
                {
                    var emptyConstructor = baseType.Resolve().GetEmptyConstructor();
                    if (emptyConstructor != null)
                    {
                        baseEmptyConstructor = moduleDefinition.ImportReference(emptyConstructor);
                    }
                    external.Add(baseType, baseEmptyConstructor);
                }
            }

            if (baseEmptyConstructor != null)
            {
                if (baseEmptyConstructor.Resolve().IsPrivate)
                {
                    processed.Add(type, null);
                    Trace.WriteLine($"Could not inject empty constructor in {type.FullName} because the base class has a private parameterless constructor");
                    continue;
                }
                var constructor = AddEmptyConstructor(type);
                processed.Add(type, constructor);
            }
            else
            {
                processed.Add(type, null);
            }
        }
    }

    static MethodDefinition AddEmptyConstructor(TypeDefinition type)
    {
        var methodAttributes = MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName;
        MethodDefinition method = new(".ctor", methodAttributes, type.Module.TypeSystem.Void);
        method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldarg_0));
        MethodReference methodReference = new(".ctor", type.Module.TypeSystem.Void,type.BaseType){HasThis = true};
        method.Body.Instructions.Add(Instruction.Create(OpCodes.Call, methodReference));
        method.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
        type.Methods.Add(method);
        return method;
    }

    static void MakeConstructorVisible(MethodDefinition typeEmptyConstructor)
    {
        if (typeEmptyConstructor.IsPublic)
        {
            return;
        }
        if (typeEmptyConstructor.DeclaringType.IsAbstract)
        {
            return;
        }

        typeEmptyConstructor.IsAssembly = false;
        typeEmptyConstructor.IsPrivate = false;
        typeEmptyConstructor.IsFamily = false;
        typeEmptyConstructor.IsPublic = true;
    }
}