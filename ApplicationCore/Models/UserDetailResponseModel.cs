using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class UserDetailResponseModel
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public IEnumerable<Income> Incomes { get; set; }
        public IEnumerable<Expenditure> Expenditures { get; set; }
    }
}
