﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Fody;
using Mono.Cecil;
using Mono.Cecil.Cil;

public partial class EmptyConstructor
{
    public void Execute(ModuleDefinition  moduleDefinition)
    {
        var queue = new Queue<TypeDefinition>(moduleDefinition.GetTypes());

        var processed = new Dictionary<TypeDefinition, MethodReference>();
        var external = new Dictionary<TypeReference, MethodReference>();
        while (queue.Count != 0)
        {
            var type = queue.Dequeue();
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
            if (type.IsStaticClass())
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
                MakeConstructorVisibleIfConfiguredAndNecessary(typeEmptyConstructor);

                processed.Add(type, typeEmptyConstructor);
                continue;
            }

            MethodReference baseEmptyConstructor;
            if (baseType is TypeDefinition baseTypeDefinition)
            {
                if (!processed.TryGetValue(baseTypeDefinition, out baseEmptyConstructor))
                {
                    queue.Enqueue(type);
                    continue;
                }
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

    MethodDefinition AddEmptyConstructor(TypeDefinition type)
    {
        var methodAttributes = MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName;
        var method = new MethodDefinition(".ctor", methodAttributes, type.Module.TypeSystem.Void);
        method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldarg_0));
        var methodReference = new MethodReference(".ctor", type.Module.TypeSystem.Void,type.BaseType){HasThis = true};
        method.Body.Instructions.Add(Instruction.Create(OpCodes.Call, methodReference));
        method.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));
        type.Methods.Add(method);
        return method;
    }

    void MakeConstructorVisibleIfConfiguredAndNecessary(MethodDefinition typeEmptyConstructor)
    {
        if (typeEmptyConstructor.IsPublic)
        {
            return;
        }
        if (typeEmptyConstructor.DeclaringType.IsAbstract)
        {
            return;
        }

        if (typeEmptyConstructor.IsFamily)
        {
            typeEmptyConstructor.IsFamily = false;
            typeEmptyConstructor.IsPublic = true;
            return;
        }

        if (typeEmptyConstructor.IsPrivate)
        {
            typeEmptyConstructor.IsPrivate = false;
            typeEmptyConstructor.Attributes = typeEmptyConstructor.Attributes | MethodAttributes.Public;
        }
    }
}