using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExpenseTrackerCLI
{
    internal class ExpenseData
    {
        public int expenseId { get; set; }
        public string description { get; set; }
        public string amount { get; set; }
        public DateTime expenseDate { get; set; }
    }
}
