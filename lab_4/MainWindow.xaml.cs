using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using lab1_E.View;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab1_E
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AccountPlan_OnClick(object sender, RoutedEventArgs e)
        {
            WindowAccountPlan or = new WindowAccountPlan();
            or.Show();
        }
        private void Deal_OnClick(object sender, RoutedEventArgs e)
        {
            WindowDeal ort = new WindowDeal();
            ort.Show();
        }
        private void Operation_OnClick(object sender, RoutedEventArgs e)
        {
            WindowOperation orv = new WindowOperation();
            orv.Show();
        }
        private void SubAccount_OnClick(object sender, RoutedEventArgs e)
        {
            WindowSubAccount cu = new WindowSubAccount();
            cu.Show();
        }
    }
}
