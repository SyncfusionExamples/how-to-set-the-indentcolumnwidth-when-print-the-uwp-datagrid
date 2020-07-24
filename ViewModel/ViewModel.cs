using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ViewModel
    {
        private ObservableCollection<OrderInfo> _orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public ViewModel()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1000, "Maria Anders", "ALFKI", 50, "Alice Mutton", 50, 5));
            _orders.Add(new OrderInfo(1001, "Ana Trujilo", "ANATR", 45, "NuNuCa Nuß-Nougat-Creme", 100, 10));
            _orders.Add(new OrderInfo(1002, "Hanna Moos", "ALFKI", 30, "Boston Crab Meat", 150, 8));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "ANTON", 30, "Raclette Courdavault", 120, 20));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "AROUT", 20, "Wimmers gute Semmelknödel", 130, 15));
            _orders.Add(new OrderInfo(1005, "Christina Berglund", "BERGS", 40, "Gorgonzola Telino", 150, 20));
            _orders.Add(new OrderInfo(1006, "Hanna Moos", "BLAUS", 25, "Chartreuse verte", 70, 12));
            _orders.Add(new OrderInfo(1007, "Frédérique Citeaux", "BLAUS", 35, "Carnarvon Tigers", 8, 25));
            _orders.Add(new OrderInfo(1009, "Laurence Lebihan", "BONAP", 55, "Thüringer Rostbratwurst", 50, 30));
            _orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "BOTTM", 25, "Vegie-spread", 40, 20));
            _orders.Add(new OrderInfo(1011, "Maria Anders", "ALFKI", 30, "Alice Mutton", 50, 5));
            _orders.Add(new OrderInfo(1012, "Frédérique Citeaux", "ANATR", 50, "NuNuCa Nuß-Nougat-Creme", 100, 10));
            _orders.Add(new OrderInfo(1013, "Anders", "ALFKI", 30, "Boston Crab Meat", 150, 8));
            _orders.Add(new OrderInfo(1014, "Antonio Moreno", "ANTON", 25, "Raclette Courdavault", 120, 20));
            _orders.Add(new OrderInfo(1015, "Maria Anders", "AROUT", 20, "Wimmers gute Semmelknödel", 130, 15));
            _orders.Add(new OrderInfo(1016, "Christina Berglund", "BERGS", 45, "Gorgonzola Telino", 150, 20));
            _orders.Add(new OrderInfo(1017, "Hanna Moos", "BLAUS", 55, "Chartreuse verte", 70, 12));
            _orders.Add(new OrderInfo(1018, "Frédérique Citeaux", "BLAUS", 35, "Carnarvon Tigers", 8, 25));
            _orders.Add(new OrderInfo(1019, "Antonio Moreno", "BONAP", 30, "Thüringer Rostbratwurst", 50, 30));
            _orders.Add(new OrderInfo(1020, "Elizabeth Lincoln", "BOTTM", 25, "Vegie-spread", 40, 20));
        }
    }
}
