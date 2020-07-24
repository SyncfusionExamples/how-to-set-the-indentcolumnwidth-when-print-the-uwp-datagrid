using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        int orderID;
        string customerId;
        string customerName;
        string productName;
        double? unitPrice;
        double quantity;
        double discount;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; RaisePropertyChanged("OrderID"); }
        }

        public string CustomerID
        {
            get { return customerId; }
            set { customerId = value; RaisePropertyChanged("CustomerID"); }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; RaisePropertyChanged("CustomerName"); }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; RaisePropertyChanged("ProductName"); }
        }

        public double? UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; RaisePropertyChanged("UnitPrice"); }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; RaisePropertyChanged("Quantity"); }
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; RaisePropertyChanged("Discount"); }
        }

        public OrderInfo(int orderId, string customerName, string customerId, double? unitprice, string productname,double _quantity,double _discount)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.CustomerID = customerId;
            this.UnitPrice = unitprice;
            this.ProductName = productname;
            this.Quantity = _quantity;
            this.Discount = _discount;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
