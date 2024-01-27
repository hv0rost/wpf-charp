using System;
using System.Collections.ObjectModel;
using lab1_E.Model;

namespace lab1_E.ViewModel
{
    class SubAccountViewModel
    {
        public ObservableCollection<SubAccount> ListSubAccount { get; set; } = new ObservableCollection<SubAccount>();

        public SubAccountViewModel()
        {
            this.ListSubAccount.Add(new SubAccount(1, 1, "Дилерские операции", 22765672));
            this.ListSubAccount.Add(new SubAccount(1, 2, "Брокерские операции", 22765672));
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var item in this.ListSubAccount)
            {
                if (max < item.Id) max = item.Id;
            }
            return max;
        }
    }
}
