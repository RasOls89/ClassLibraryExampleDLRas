using ClassLibraryExampleDLRas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExampleDLRas
{
    internal class UnitOfWork : IUnitOfWork
    {
        public ITypeRepository TypeRepository => throw new NotImplementedException();

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
