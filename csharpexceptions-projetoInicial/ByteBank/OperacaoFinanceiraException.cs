﻿using System;
using System.Runtime.Serialization;

namespace ByteBank
{
    [Serializable]
    internal class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {
        }

        public OperacaoFinanceiraException(string message) : base(message)
        {
        }

        public OperacaoFinanceiraException(string message, Exception innerException) : base(message, innerException)
        {
        }
        
    }
}