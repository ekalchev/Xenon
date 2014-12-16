using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xenon.Common;

namespace Xenon.Data
{
    public class Question
    {
        public Question()
        {
            Tags = new List<Tag>();
        }

        public Int64 QuestionId { get; set; }
        public Int64 QuestionnaireId { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public DifficultyLevel Difficulty { get; set; }
    }
}
