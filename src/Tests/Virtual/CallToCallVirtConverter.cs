﻿using Mono.Cecil;
using Mono.Cecil.Cil;

public partial class Virtual
{
    public void ConvertCallToCallVirtual(ModuleDefinition module)
    {
        foreach (var type in module.GetTypes())
        {
            if (type.IsInterface)
            {
                continue;
            }
            if (type.IsEnum)
            {
                continue;
            }
            foreach (var methodDefinition in type.Methods)
            {
                Replace(methodDefinition);
            }
        }
    }

    void Replace(MethodDefinition? methodDefinition)
    {
        if (methodDefinition == null)
        {
            return;
        }
        if (methodDefinition.IsAbstract)
        {
            return;
        }
        //for delegates
        if (methodDefinition.Body == null)
        {
            return;
        }
        foreach (var instruction in methodDefinition.Body.Instructions)
        {
            if (instruction.OpCode != OpCodes.Call)
            {
                continue;
            }

            foreach (var method in MethodCache)
            {
                if (instruction.Operand == method)
                {
                    instruction.OpCode = OpCodes.Callvirt;
                }
            }
        }
    }
}