/*
 * Tencent is pleased to support the open source community by making InjectFix available.
 * Copyright (C) 2019 THL A29 Limited, a Tencent company.  All rights reserved.
 * InjectFix is licensed under the MIT License, except for the third-party components listed in the file 'LICENSE' which may be subject to their corresponding license terms. 
 * This file is subject to the terms and conditions defined in file 'LICENSE', which is part of this source code package.
 */

namespace IFix.Core
{
    public enum Code
    {
        Conv_Ovf_I4_Un = 0,
        Ldelem_R4,
        Jmp,
        Rem_Un,
        Shr,
        Stind_I,
        Conv_Ovf_U4_Un,
        Stelem_I4,
        Stelem_I,
        Nop,
        Initobj,
        Ldc_I4,
        Conv_I4,
        Ldelem_Ref,
        Div_Un,
        Bge_Un,
        Conv_I8,
        Stfld,
        Conv_U,
        Ldind_I4,
        Beq,
        Switch,
        Ldind_Ref,
        Ldind_U4,
        Isinst,
        Callvirt,
        Stelem_R8,
        Stind_I2,
        Unbox,
        Mul_Ovf_Un,
        Stind_I4,
        No,
        Arglist,
        Sub_Ovf,
        Ldelem_Any,
        Ret,
        Ldelem_I2,
        Unaligned,
        Ldsfld,
        Initblk,
        Ldelema,
        Ldc_R4,
        Ldind_U2,
        Endfinally,
        Mul,
        Conv_Ovf_I2_Un,
        Rem,
        Conv_R4,
        Conv_Ovf_I,
        Sub,
        Ldfld,
        Stind_I8,
        Conv_U8,
        Ckfinite,
        Clt,
        Shl,
        Newarr,
        Conv_Ovf_I8,
        Conv_I,
        Conv_Ovf_I_Un,
        Stelem_I8,
        Bgt_Un,
        Stsfld,
        Ldelem_U2,
        Stind_R8,
        Mkrefany,
        Clt_Un,
        Bne_Un,
        Conv_Ovf_U_Un,
        Stelem_I2,
        Box,
        Conv_Ovf_U8,
        Ldloc,
        Conv_Ovf_I4,
        Stloc,
        Neg,
        Ldind_R8,
        Add,
        Ldind_I2,
        Add_Ovf_Un,
        Break,
        Conv_Ovf_U1_Un,
        Conv_R8,
        Ldtype,
        Or,
        Call,
        Conv_Ovf_U4,
        StackSpace,
        Ldsflda,
        Cpblk,
        Conv_Ovf_U2,
        Ldarg,
        Ldind_I1,
        Ldflda,
        Sizeof,
        Not,
        Dup,
        Conv_Ovf_I2,
        Conv_Ovf_U,
        Cpobj,
        Ldind_R4,
        Volatile,
        Callvirtvirt,
        Mul_Ovf,
        Ldelem_U1,
        Ldobj,
        CallExtern,
        Bgt,
        Ldnull,
        Blt_Un,
        Br,
        Conv_U4,
        Ldlen,
        Conv_Ovf_U8_Un,
        Ldvirtftn2,
        Refanytype,
        Add_Ovf,
        Newobj,
        Starg,
        Blt,
        Conv_R_Un,
        Ldftn,
        Rethrow,
        Shr_Un,
        Conv_Ovf_U1,
        Conv_Ovf_I8_Un,
        Ldelem_I8,
        Ble,
        Stobj,
        Brfalse,
        Conv_Ovf_U2_Un,
        Newanon,
        Leave,
        Stelem_R4,
        Cgt_Un,
        Conv_I2,
        Ldc_I8,
        Ldelem_I,
        Ldelem_I1,
        And,
        Stelem_I1,
        Cgt,
        Castclass,
        Ldc_R8,
        Xor,
        Sub_Ovf_Un,
        Ldind_I,
        Brtrue,
        Stelem_Any,
        Localloc,
        Stind_I1,
        Ldind_U1,
        Ldelem_R8,
        Readonly,
        Div,
        Unbox_Any,
        Ldind_I8,
        Conv_Ovf_I1,
        Bge,
        Throw,
        Conv_Ovf_I1_Un,
        Ldvirtftn,
        Ldelem_I4,
        Conv_U2,
        Stind_Ref,
        Pop,
        Stelem_Ref,
        Ble_Un,
        Ldtoken,
        Conv_U1,
        Ldarga,
        Tail,
        Stind_R4,
        Constrained,
        Ceq,
        Ldloca,
        Conv_I1,
        Refanyval,
        Ldelem_U4,
        Endfilter,
        Ldstr,
        //Pseudo instruction
        StackSpace,
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public struct Instruction
    {
        /// <summary>
        /// 指令MAGIC
        /// </summary>
        public const ulong INSTRUCTION_FORMAT_MAGIC = 317431043901;

        /// <summary>
        /// 当前指令
        /// </summary>
        public Code Code;

        /// <summary>
        /// 操作数
        /// </summary>
        public int Operand;
    }

    public enum ExceptionHandlerType
    {
        Catch = 0,
        Filter = 1,
        Finally = 2,
        Fault = 4
    }

    public sealed class ExceptionHandler
    {
        public System.Type CatchType;
        public int CatchTypeId;
        public int HandlerEnd;
        public int HandlerStart;
        public ExceptionHandlerType HandlerType;
        public int TryEnd;
        public int TryStart;
    }
}
