using System;

namespace Banco
{
    public class SaqueMaiorQueFundoException : Exception
    {
        public SaqueMaiorQueFundoException(string message)
            : base(message)
        {
            
        }
    }
}