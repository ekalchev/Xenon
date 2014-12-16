using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xenon.Common;

namespace Xenon.Data
{
    public class Questionnaire
    {
        public Questionnaire()
        {
            Questions = new List<Question>();
        }

        public Int64 QuestionnaireId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
