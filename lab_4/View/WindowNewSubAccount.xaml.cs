using System.Windows;

namespace lab1_E.View
{
    public partial class WindowNewSubAccount : Window
    {
        public WindowNewSubAccount()
        {
            InitializeComponent();
        }
        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}