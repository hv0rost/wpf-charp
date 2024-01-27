using lab1_E.Model;


namespace lab1_E.Helpers
{
    class FindSubAccount
    {
        int id;
        public FindSubAccount(int id)
        {
            this.id = id;
        }
        public bool SubAccountPredicate(SubAccount val)
        {
            return val.Id == id;
        }
    }
}
