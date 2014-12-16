using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xenon.Common
{
    public interface IUnitOfWork
    {
        //public ObjectContext Context { get; private set; }
        void SaveChanges();
    }
}
