using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.Model
{
    class Deal
    {
        public int Id { get; set; }
        public int Agreement { get; set; }
        public string Tiker { get; set; }
        public int Order { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalCost { get; set; }
        public string Trader { get; set; }
        public double Commission { get; set; }

        public Deal() { }

        public Deal(int Id, int Agreement, string Tiker, int Order, int Number, DateTime Date, int Quantity, double Price, double TotalCost, double Commission, string Trader)
        {
            this.Id = Id;
            this.Agreement = Agreement;
            this.Tiker = Tiker;
            this.Order = Order;
            this.Number = Number;
            this.Date = Date;
            this.Quantity = Quantity;
            this.TotalCost = TotalCost;
            this.Commission = Commission;
            this.Price = Price;
            this.Trader = Trader;
        }
    }
}
