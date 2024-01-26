using lab1_E.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.Helper
{
    class FindAccountPlan
    {
        int id;
        public FindAccountPlan(int id)
        {
            this.id = id;
        }
        public bool AccountPlanPredicate(AccountPlan val)
        {
            return val.Id == id;
        }
    }
}
