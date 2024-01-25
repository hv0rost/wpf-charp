﻿using System;
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
            this.ListSubAccount.Add(new SubAccount(1, 1, "Брокерские операции", 22765672));
        }
    }
}
