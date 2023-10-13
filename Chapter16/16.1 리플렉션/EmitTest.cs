using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using UnityEngine;

public class EmitTest : MonoBehaviour
{
    void Start()
    {
        AssemblyBuilder newAssembly = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

        ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");
        TypeBuilder newType = newModule.DefineType("Sum1To100");

        MethodBuilder newMethod = newType.DefineMethod(
			"Calculator",
            MethodAttributes.Public,
            typeof(int),
            new Type[0]);

        ILGenerator il = newMethod.GetILGenerator();
        
        il.Emit(OpCodes.Ldc_I4,1);
        for(int i = 2; i <=100; i++)
        {
            il.Emit(OpCodes.Ldc_I4, i);
            il.Emit(OpCodes.Add);
        }

        il.Emit(OpCodes.Ret);
        newType.CreateType();

        object sum1To100 = Activator.CreateInstance(newType);
        MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculator");
        Debug.Log(sum1To100, null);
    }

   
}
