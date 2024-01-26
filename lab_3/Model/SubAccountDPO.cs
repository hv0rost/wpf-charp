using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.Model
{
    class SubAccountDPO
    {
        public int Id { get; set; }
        public string AccountPlanID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public SubAccountDPO() { }

        public SubAccountDPO(int Id, string AccountPlanID, string Name, int Number)
        {
            this.Id = Id;
            this.AccountPlanID = AccountPlanID;
            this.Name = Name;
            this.Number = Number;
        }
    }
}