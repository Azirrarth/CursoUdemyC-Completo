using System;


namespace Exe1.Entites.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string messege) : base(messege)
        {
        }


    }
}
