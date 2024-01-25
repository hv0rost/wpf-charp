using lab1_E.Helper;
using lab1_E.Model;
using lab1_E.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab1_E.View
{
    /// <summary>
    /// Логика взаимодействия для WindowOrderVeriety.xaml
    /// </summary>
        public partial class WindowSubAccount : Window
        {
            public WindowSubAccount()
            {
                InitializeComponent();

                SubAccountViewModel subAccountVM = new SubAccountViewModel();
                ListSubAccount.ItemsSource = subAccountVM.ListSubAccount;

                AccountPlanViewModel AccountPlanVM = new AccountPlanViewModel();
                List<AccountPlan> accountPlanList = new List<AccountPlan>();

                foreach (AccountPlan val in AccountPlanVM.ListAccountPlan)
                {
                    accountPlanList.Add(val);
                }

                ObservableCollection<SubAccountDPO> subAccounts = new ObservableCollection<SubAccountDPO>();

                FindAccountPlan finderAccounPlan;

                foreach (var item in subAccountVM.ListSubAccount)
                {
                    finderAccounPlan = new FindAccountPlan(item.AccountPlanID);
                AccountPlan accountPLan = accountPlanList.Find(new Predicate<AccountPlan>(finderAccounPlan.AccountPlanPredicate));

                    subAccounts.Add(new SubAccountDPO
                    {
                        Id = item.Id,
                        AccountPlanID = accountPLan.Name,
                        Name = item.Name,
                        Number = item.Number,
                });
                ListSubAccount.ItemsSource = subAccounts;
            }
        }
    }
}
