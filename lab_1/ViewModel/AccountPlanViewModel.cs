using lab1_E.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.ViewModel
{
    class AccountPlanViewModel
    {
        public ObservableCollection<AccountPlan> ListAccountPlan { get; set; } = new ObservableCollection<AccountPlan>();

        public AccountPlanViewModel()
        {
            this.ListAccountPlan.Add(new AccountPlan(1, "Основные средства", "Расчетный", 1));
            this.ListAccountPlan.Add(new AccountPlan(2, "Амортизация основных средств", "Ваоютный", 2));
        }
    }
}

