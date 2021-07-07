using System;
namespace Atv_Exceptions.Entidades.Exceçoes
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message){
        }
    }
}
