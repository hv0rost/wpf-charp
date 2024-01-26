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
                Title = "Новая валюта",
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
                Title = "Редактирование валюты",
                Owner = this
            };

            AccountPlan сurrency = ListAccountPlan.SelectedItem as AccountPlan;

            if (сurrency != null)
            {
                AccountPlan tempAccountPlan = new AccountPlan
                {
                    Id = сurrency.Id,
                    Type = сurrency.Type,
                    Name = сurrency.Name,
                    Number = сurrency.Number,
            };

                winNewAccountPlan.DataContext = tempAccountPlan;
                if (winNewAccountPlan.ShowDialog() == true)
                {
                    сurrency.Id = tempAccountPlan.Id;
                    сurrency.Type = tempAccountPlan.Type;
                    сurrency.Name = tempAccountPlan.Name;
                    сurrency.Number = tempAccountPlan.Number;

                    ListAccountPlan.ItemsSource = null;
                    ListAccountPlan.ItemsSource = vmViewModel.ListAccountPlan;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать валютудля редактирования",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            AccountPlan сurrency = (AccountPlan)ListAccountPlan.SelectedItem;

            if (сurrency != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные валюте: [ "
                    + сurrency.Id + " ]", "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);

                if (result == MessageBoxResult.OK) vmViewModel.ListAccountPlan.Remove(сurrency);
                else MessageBox.Show("Необходимо выбрать валюту для удаления", "Предупреждение",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

    }
}
