using lab1_E.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.ViewModel
{
    class DealViewModel
    {
        public ObservableCollection<Deal> ListDeal { get; set; } = new ObservableCollection<Deal>();

        public DealViewModel()
        {
            this.ListDeal.Add(new Deal(1, 123213, "BTC", 9, 21, new DateTime(2023, 12, 05), 255, 255000.0, 32221122.9, 0.1, "2A312FFS11" )); ;
            this.ListDeal.Add(new Deal(2, 123213, "EFR", 19, 221, new DateTime(2023, 12, 11), 2551, 2525000.0, 312221122.9, 0.16, "2A312FFS11" )); ;
        }
    }
}