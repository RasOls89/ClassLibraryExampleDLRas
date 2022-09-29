using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryExampleDLRas.Repository;


namespace ClassLibraryExampleDLRas
{
    internal interface IUnitOfWork : IDisposable
    {

            ITypeRepository TypeRepository { get; }
            
            int Complete();
        
    }
}

