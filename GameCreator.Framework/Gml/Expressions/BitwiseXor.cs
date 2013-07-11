﻿using System;
using GameCreator.Framework.Intermediate;
namespace GameCreator.Framework.Gml
{
    class BitwiseXor : Expression
    {
        Expression expr1, expr2;
        public BitwiseXor(Expression e1, Expression e2, int line, int col) : base(line, col) { expr1 = e1; expr2 = e2; }
        public override Value Eval()
        {
            Value v1 = expr1.Eval(), v2 = expr2.Eval();
            if (!(v1.IsReal && v2.IsReal)) Error("Wrong type of arguments for ^.");
            return (double)(Convert.ToInt64(v1.Real) | Convert.ToInt64(v2.Real));
        }

        public override void Emit(Intermediate.FunctionBuilder builder)
        {
            expr1.Emit(builder);
            expr2.Emit(builder);
            builder.Emit(OpCode.BitwiseXor);
        }
    }
}