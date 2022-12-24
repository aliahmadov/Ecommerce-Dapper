using E_CommerceDapper.DataAccess.Entites;
using E_CommerceDapper.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace E_CommerceDapper.Domain.ViewModels
{
    public class OrderViewModel:BaseViewModel
    {
		private OrderDetails order;

		public OrderDetails Order
        {
			get { return order; }
			set { order = value; OnPropertyChanged(); }
		}


      

        public RelayCommand	SubmitCommand { get; set; }
		public OrderViewModel(Product product)
		{
			Order = new OrderDetails();
			Order.OrderID = 10248;
			Order.Discount = 0;
			Order.ProductId = product.ProductID;
			Order.UnitPrice = product.UnitPrice;
			SubmitCommand = new RelayCommand((o) =>
			{
				App.DB.OrderDetailsRepository.Add(Order);
				MessageBox.Show("Order has been implemented successfully");
				Order.Quantity = 0;
			});
		}

	}
}
