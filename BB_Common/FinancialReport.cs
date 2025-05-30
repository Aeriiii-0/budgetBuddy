using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_Common
{
    public class FinancialReport
    {
        public int expense_ID { get; set; }
        public int account_id { get; set; }
        public string DayOfWeek { get; set; }
        public double TotalExpense { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
