using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xenon.Common;

namespace Xenon.Data
{
    public class Tag
    {
        public Int64 TagId { get; set; }
        public string Text { get; set; }
    }
}
