using Dapper;
using E_CommerceDapper.DataAccess.Abstractions;
using E_CommerceDapper.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDapper.DataAccess.Concretes
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly string _connectionString;

        public OrderDetailsRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }
        public void Add(OrderDetails data)
        {
            using (var connection=new SqlConnection(_connectionString))
            {
                connection.Execute(@"INSERT INTO [Order Details](OrderID,ProductID,UnitPrice,Quantity,Discount)
                                      VALUES(@orderId,@pId,@unitPrice,@qty,@discount)",
                                     new
                                     {
                                         orderId=data.OrderID,
                                         pId=data.ProductId,
                                         unitPrice=data.UnitPrice,
                                         qty=data.Quantity,
                                         discount=data.Discount
                                     });
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetails Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetails> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDetails data)
        {
            throw new NotImplementedException();
        }
    }
}
