using lab1_E.Model;
using System.Collections.ObjectModel;


namespace lab1_E.ViewModel
{
    class AccountPlanViewModel
    {
        public ObservableCollection<AccountPlan> ListAccountPlan { get; set; } = new ObservableCollection<AccountPlan>();

        public AccountPlanViewModel()
        {
            this.ListAccountPlan.Add(new AccountPlan(1, "Основные средства", "Расчетный", 1));
            this.ListAccountPlan.Add(new AccountPlan(2, "Амортизация основных средств", "Валютный", 2));
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var item in this.ListAccountPlan)
            {
                if (max < item.Id) max = item.Id;
            }
            return max;
        }
    }
}

