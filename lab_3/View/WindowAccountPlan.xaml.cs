using lab1_E.Model;
using lab1_E.ViewModel;
using System;
using System.Windows;


namespace lab1_E.View
{
    public partial class WindowAccountPlan : Window
    {
        AccountPlanViewModel vmViewModel = new AccountPlanViewModel();
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
                Title = "Новая план счетов",
                Owner = this
            };

            int lastIdIndex = vmViewModel.MaxId() + 1;
            AccountPlan accountPlan = new AccountPlan
            {
                Id = lastIdIndex,
            };

            winNewAccountPlan.DataContext = accountPlan;
            if (winNewAccountPlan.ShowDialog() == true)
            {
                vmViewModel.ListAccountPlan.Add(accountPlan);
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
                    ListAccountPlan.ItemsSource = vmViewModel.ListAccountPlan;
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
                    + accountPlan.Name + " ]", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

                if (result == MessageBoxResult.OK) vmViewModel.ListAccountPlan.Remove(accountPlan);
                else MessageBox.Show("Необходимо выбрать план счетов для удаления", "Предупреждение",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

    }
}
