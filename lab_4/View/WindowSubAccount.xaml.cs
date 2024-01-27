using lab1_E.Helper;
using lab1_E.Helpers;
using lab1_E.Model;
using lab1_E.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace lab1_E.View
{

    public partial class WindowSubAccount : Window
    {
        SubAccountViewModel vmSubAccount = new SubAccountViewModel();
        private SubAccountViewModel vmOrder = new SubAccountViewModel();
        private ObservableCollection<SubAccountDPO> subAccountDPOs;
        AccountPlanViewModel AccountPlanVM = new AccountPlanViewModel();
        List<AccountPlan> accountPlanList = new List<AccountPlan>();
        public WindowSubAccount()
        {
            InitializeComponent();

            SubAccountViewModel subAccountVM = new SubAccountViewModel();
            ListSubAccount.ItemsSource = subAccountVM.ListSubAccount;

            foreach (AccountPlan val in AccountPlanVM.ListAccountPlan)
            {
                accountPlanList.Add(val);
            }

            subAccountDPOs = new ObservableCollection<SubAccountDPO>();

            FindAccountPlan finderAccounPlan;

            foreach (var item in subAccountVM.ListSubAccount)
            {
                finderAccounPlan = new FindAccountPlan(item.AccountPlanID);
                AccountPlan accountPLan = accountPlanList.Find(new Predicate<AccountPlan>(finderAccounPlan.AccountPlanPredicate));

                subAccountDPOs.Add(new SubAccountDPO
                {
                    Id = item.Id,
                    AccountPlanID = accountPLan.Name,
                    Name = item.Name,
                    Number = item.Number,
                });
                ListSubAccount.ItemsSource = subAccountDPOs;
            }
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewSubAccount winNewSubAccount = new WindowNewSubAccount
            {
                Title = "Новый субсчет",
                Owner = this
            };

            int lastIdIndex = vmSubAccount.MaxId() + 1;
            SubAccountDPO subAccountDPO = new SubAccountDPO
            {
                Id = lastIdIndex,
                Name = "",
                Number = 0,
            };

            winNewSubAccount.DataContext = subAccountDPO;
            winNewSubAccount.cb_AccountPlanID.ItemsSource = accountPlanList;
            Console.WriteLine(accountPlanList);
            if (winNewSubAccount.ShowDialog() == true)
            {
                AccountPlan accountPlan = (AccountPlan)winNewSubAccount.cb_AccountPlanID.SelectedValue;
                subAccountDPO.AccountPlanID = accountPlan.Name;

                subAccountDPOs.Add(subAccountDPO);

                SubAccount subAccount = new SubAccount();
                subAccount = subAccount.CopyFromSubAccountDPO(subAccountDPO);
                vmSubAccount.ListSubAccount.Add(subAccount);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewSubAccount winNewSubAccount = new WindowNewSubAccount
            {
                Title = "Редактирование субсчета",
                Owner = this
            };

            SubAccountDPO subAccountDPO = (SubAccountDPO)ListSubAccount.SelectedValue;
            SubAccountDPO tempSubAccountDpo;

            if (subAccountDPO != null)
            {
                tempSubAccountDpo = new SubAccountDPO
                {
                    Id = subAccountDPO.Id,
                    AccountPlanID = subAccountDPO.AccountPlanID,
                    Name = subAccountDPO.Name,
                    Number = subAccountDPO.Number
                    
                };

                winNewSubAccount.DataContext = tempSubAccountDpo;

                winNewSubAccount.cb_AccountPlanID.ItemsSource = accountPlanList;
                winNewSubAccount.cb_AccountPlanID.Text = tempSubAccountDpo.AccountPlanID;
                if (winNewSubAccount.ShowDialog() == true)
                {
                    AccountPlan accountPlan = (AccountPlan)winNewSubAccount.cb_AccountPlanID.SelectedValue;
                    subAccountDPO.Id = tempSubAccountDpo.Id;
                    subAccountDPO.AccountPlanID = accountPlan.Name;
                    subAccountDPO.Name = tempSubAccountDpo.Name;
                    subAccountDPO.Number = tempSubAccountDpo.Number;

                    FindSubAccount finder = new FindSubAccount(subAccountDPO.Id);
                    List<SubAccount> listSubAccount= vmSubAccount.ListSubAccount.ToList();
                    SubAccount subAccount = listSubAccount.Find(new Predicate<SubAccount>(finder.SubAccountPredicate));
                    subAccount = subAccount.CopyFromSubAccountDPO(subAccountDPO);

                    ListSubAccount.ItemsSource = null;
                    ListSubAccount.ItemsSource = subAccountDPOs;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать субсчета для редактирования",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            SubAccountDPO subAccount = (SubAccountDPO)ListSubAccount.SelectedItem;

            if (subAccount != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить субсчет: \n"
                    + subAccount.Name, "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

                if (result == MessageBoxResult.OK)
                {
                    subAccountDPOs.Remove(subAccount);
                    SubAccount subAccountTemp = new SubAccount();
                    subAccountTemp = subAccountTemp.CopyFromSubAccountDPO(subAccount);
                    vmSubAccount.ListSubAccount.Remove(subAccountTemp);
                }
                else MessageBox.Show("Необходимо выбрать субсчет для удаления", "Предупреждение",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
    }
}
