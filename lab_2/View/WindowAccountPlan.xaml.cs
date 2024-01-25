using lab1_E.ViewModel;
using System.Windows;


namespace lab1_E.View
{
    /// <summary>
    /// Логика взаимодействия для WindowCurrency.xaml
    /// </summary>
    public partial class WindowAccountPlan : Window
    {
        public WindowAccountPlan()
        {
            InitializeComponent();
            AccountPlanViewModel vmViewModel = new AccountPlanViewModel();
            ListAccountPlan.ItemsSource = vmViewModel.ListAccountPlan;
        }
    }
}
