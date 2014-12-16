using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xenon.Common;
using Xenon.Data;

namespace Xenon.Server
{
    public class QuestionnaireRepositoryManager : IUnitOfWork, IDisposable
    {
        private readonly QuestionnaireContext Context = new QuestionnaireContext();
        public IGenericRepository<Questionnaire> QuestionnaireRepository { get; private set; }

        private bool disposed = false;

        public QuestionnaireRepositoryManager()
        {
            QuestionnaireRepository = new QuestionnaireRepository(Context);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
