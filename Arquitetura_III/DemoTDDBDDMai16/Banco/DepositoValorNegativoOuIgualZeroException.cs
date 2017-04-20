using System;

namespace Banco
{
    public class DepositoValorNegativoOuIgualZeroException : Exception
    {
        public DepositoValorNegativoOuIgualZeroException(string message)
            : base(message)
        {
            
        }
    }
}