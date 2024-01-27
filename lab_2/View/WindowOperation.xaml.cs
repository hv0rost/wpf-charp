using lab1_E.ViewModel;
using System.Windows;


namespace lab1_E.View
{
    /// <summary>
    /// Логика взаимодействия для WindowOrderType.xaml
    /// </summary>
    public partial class WindowOperation : Window
    {
        public WindowOperation()
        {
            InitializeComponent();

            OperationViewModel vmOperation = new OperationViewModel();
            ListOperation.ItemsSource = vmOperation.ListOperation;
        }
    }
}
