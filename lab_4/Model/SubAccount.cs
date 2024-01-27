using lab1_E.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace lab1_E.Model
{
    class SubAccount
    {
        public int Id { get; set; }
        public int AccountPlanID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public SubAccount() { }

        public SubAccount(int Id, int AccountPlanID, string Name, int Number)
        {
            this.Id = Id;
            this.AccountPlanID = AccountPlanID;
            this.Name = Name;
            this.Number = Number;
        }

        public SubAccount CopyFromSubAccountDPO(SubAccountDPO subAccountDPO)
        {
            AccountPlanViewModel vmAccountPlan = new AccountPlanViewModel();
            int subAccountId = 0;

            foreach (var item in vmAccountPlan.ListAccountPlan)
            {
                if (item.Name.ToString() == subAccountDPO.AccountPlanID)
                {
                    subAccountId = item.Id;
                    break;
                }
            }

            if (subAccountId != 0)
            {
                this.Id = subAccountDPO.Id;
                this.AccountPlanID = subAccountId;
                this.Name = subAccountDPO.Name;
                this.Number = subAccountDPO.Number;

            }
            return this;
        }
    }
}
