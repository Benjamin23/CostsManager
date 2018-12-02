using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManager.Common
{
    public class BaseFilter
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string SearchQuery { get; set; }
        public Guid UserId { get; set; }
    }
}
