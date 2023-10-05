using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class ExpressionExample : MonoBehaviour
{

    void Start()
    {
        Expression const1 = Expression.Constant(1);
        Expression const2 = Expression.Constant(2);

        Expression leftExp = Expression.Multiply(const1, const2);  // 1 * 2

        Expression prama1 = Expression.Parameter(typeof(int)); //x를 위한 변수
        Expression prama2 = Expression.Parameter(typeof(int)); //y를 위한 변수

        Expression rightExp = Expression.Subtract(prama1, prama2); //x-y

		Expression exp = Expression.Add(leftExp, rightExp);

        Expression<Func<int, int, int>> expression = Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>
            (exp, new ParameterExpression[]
            {(ParameterExpression)prama1,(ParameterExpression)prama2});

		Func<int, int, int> func = expression.Compile();

        Debug.Log("1*2+(7-8) : " +func(7, 8));  //1
	}


}
