using lab1_E.ViewModel;
using System.Windows;


namespace lab1_E.View
{

    public partial class WindowOperation : Window
    {
        public WindowOperation()
        {
            InitializeComponent();

            OperationViewModel vmViewModel = new OperationViewModel();
            ListOperation.ItemsSource = vmViewModel.ListOperation;
        }
    }
}
