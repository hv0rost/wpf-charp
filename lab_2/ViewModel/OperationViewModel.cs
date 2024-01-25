using lab1_E.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_E.ViewModel
{
    class OperationViewModel
    {
        public ObservableCollection<Operation> ListOperation { get; set; } = new ObservableCollection<Operation>();

        public OperationViewModel()
        {
            this.ListOperation.Add(new Operation(1, 1, 2, 223211, new DateTime(2023, 12, 05), "ПОКУПКА", 1232.1, 21313.0, 2132142.0));
            this.ListOperation.Add(new Operation(2, 2, 1, 221111, new DateTime(2023, 12, 15), "ПРОДАЖА", 12522.1, 2131913.0, 21532142.0));
        }
    }
}