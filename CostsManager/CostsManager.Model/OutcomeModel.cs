using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostsManager.Model
{
    public class OutcomeModel : BaseModel
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public decimal Amount { get; set; }
    }
}
