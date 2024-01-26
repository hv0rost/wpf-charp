using System.Windows;
using lab1_E.ViewModel;

namespace lab1_E.View
{
    public partial class WindowDeal : Window
    {
        public WindowDeal()
        {
            InitializeComponent();

            DealViewModel vmViewModel = new DealViewModel();
            ListDeal.ItemsSource = vmViewModel.ListDeal;

        }
    }
}
