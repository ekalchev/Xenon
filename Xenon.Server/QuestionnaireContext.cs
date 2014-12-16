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
    public class QuestionnaireContext : DbContext
    {
        static QuestionnaireContext()
        {
            Database.SetInitializer<QuestionnaireContext>(null);
        }

        public QuestionnaireContext()
        {
            this.Database.Log = Console.WriteLine;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questionnaire>().HasMany(entity => entity.Questions);

            modelBuilder.Entity<Question>().HasMany(entity => entity.Tags).WithMany()
                .Map(x =>
                    {
                        x.MapLeftKey("QuestionId");
                        x.MapRightKey("TagId");
                        x.ToTable("m_Questions_Tags");
                    });
        }

        public DbSet<Questionnaire> Questionnaires { get; set; }
    }
}
