using lab1_E.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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

        public SubAccountDPO CopyFromSubAccount(SubAccount subAccount)
        {
            SubAccountDPO subAccountDPO = new SubAccountDPO();

            AccountPlanViewModel vmAccountPlan = new AccountPlanViewModel();

            string accountPlan = string.Empty;
            foreach (var item in vmAccountPlan.ListAccountPlan)
            {
                if (item.Id == subAccount.AccountPlanID)
                {
                    accountPlan = item.Name.ToString();
                    break;
                }
            }

            if (accountPlan != string.Empty)
            {
                subAccountDPO.Id = subAccount.Id;
                subAccountDPO.AccountPlanID = accountPlan;
                subAccountDPO.Name = subAccount.Name;
                subAccountDPO.Number = subAccount.Number;
               
            }
            return subAccountDPO;
        }
    }
}