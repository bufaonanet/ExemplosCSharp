using System;
namespace Excecao.Entities.Exptions
{
    class DomainExeption : ApplicationException
    {
        public DomainExeption(string message) : base(message)
        {

        }

    }
}
