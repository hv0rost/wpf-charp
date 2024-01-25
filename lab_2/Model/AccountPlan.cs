using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.Model
{
    class AccountPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }



        public AccountPlan() { }

        public AccountPlan(int Id, string Type, string Name, int Number)
        {
            this.Id = Id;
            this.Type = Type;
            this.Name = Name;
            this.Number = Number;
        }
    }
}
