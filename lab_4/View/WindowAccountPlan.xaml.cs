using lab1_E.Model;
using lab1_E.ViewModel;
using System;
using System.Windows;


namespace lab1_E.View
{
    public partial class WindowAccountPlan : Window
    {
        AccountPlanViewModel vmAccountPlan = new AccountPlanViewModel();
        public WindowAccountPlan()
        {
            InitializeComponent();
            AccountPlanViewModel vmViewModel = new AccountPlanViewModel();
            ListAccountPlan.ItemsSource = vmViewModel.ListAccountPlan;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewAccountPlan winNewAccountPlan = new WindowNewAccountPlan
            {
                Title = "Новый план счетов",
                Owner = this
            };

            int lastIdIndex = vmAccountPlan.MaxId() + 1;
            AccountPlan accountPlan = new AccountPlan
            {
                Id = lastIdIndex,
            };

            winNewAccountPlan.DataContext = accountPlan;
            if (winNewAccountPlan.ShowDialog() == true)
            {
                vmAccountPlan.ListAccountPlan.Add(accountPlan);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewAccountPlan winNewAccountPlan = new WindowNewAccountPlan
            {
                Title = "Редактирование плана счетов",
                Owner = this
            };

            AccountPlan accountPlan = ListAccountPlan.SelectedItem as AccountPlan;

            if (accountPlan != null)
            {
                AccountPlan tempAccountPlan = new AccountPlan
                {
                    Id = accountPlan.Id,
                    Type = accountPlan.Type,
                    Name = accountPlan.Name,
                    Number = accountPlan.Number,
            };

                winNewAccountPlan.DataContext = tempAccountPlan;
                if (winNewAccountPlan.ShowDialog() == true)
                {
                    accountPlan.Id = tempAccountPlan.Id;
                    accountPlan.Type = tempAccountPlan.Type;
                    accountPlan.Name = tempAccountPlan.Name;
                    accountPlan.Number = tempAccountPlan.Number;

                    ListAccountPlan.ItemsSource = null;
                    ListAccountPlan.ItemsSource = vmAccountPlan.ListAccountPlan;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать план счетов для редактирования",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            AccountPlan accountPlan = (AccountPlan)ListAccountPlan.SelectedItem;

            if (accountPlan != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить план счетов: [ "
                    + accountPlan.Id + " ]", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

                if (result == MessageBoxResult.OK) vmAccountPlan.ListAccountPlan.Remove(accountPlan);
                else MessageBox.Show("Необходимо выбрать план счетов", "Предупреждение",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

    }
}
