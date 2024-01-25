using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.Model
{
    class Operation
    {
        public int Id { get; set; }
        public int DealID { get; set; }
        public int SubAccountID { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public double Sum { get; set; }
        public double SaldoInput { get; set; }
        public double SaldoOutput { get; set; }

        public Operation() { }

        public Operation(int Id, int DealID, int SubAccountID, int Number, DateTime Date, string Type, double Sum, double SaldoInput, double SaldoOutput)
        {
            this.Id = Id;
            this.DealID = DealID;
            this.SubAccountID = SubAccountID;
            this.Number = Number;
            this.Date = Date;
            this.Type = Type;
            this.Sum = Sum;
            this.SaldoInput = SaldoInput;
            this.SaldoOutput = SaldoOutput;
        }
    }
}
