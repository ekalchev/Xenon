using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xenon.Common;
using Xenon.Data;

namespace Xenon.Server
{
    public class QuestionnaireRepository : IGenericRepository<Questionnaire>
    {
        private readonly QuestionnaireContext Context;

        public QuestionnaireRepository(QuestionnaireContext context)
        {
            this.Context = context;
        }

        public void Add(Questionnaire entity)
        {
            Context.Questionnaires.Add(entity);
        }

        public void Remove(Questionnaire entity)
        {
            Context.Questionnaires.Remove(entity);
        }

        public IQueryable<Questionnaire> Find(Expression<Func<Questionnaire, bool>> predicate)
        {
            return Context.Questionnaires.AsQueryable<Questionnaire>().Where(predicate);
        }
        public IQueryable<Questionnaire> GetAll()
        {
            return Context.Questionnaires.AsQueryable<Questionnaire>();
        }
    }
}
