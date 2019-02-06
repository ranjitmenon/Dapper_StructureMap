using Dapper;
using EP.DAL.Models;
using EP.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Customer GetCustomer(int Id)
        {
            var sql = $@"SELECT * FROM Customers c WHERE c.CustomerID = {Id} ";
            return _unitOfWork.GetConnection().QuerySingle<Customer>(sql, null, _unitOfWork.DbTransaction);
        }

        public List<Customer> GetCustomers()
        {
            var sql = @"SELECT * FROM Customers";
            return _unitOfWork.GetConnection().Query<Customer>(sql, null, _unitOfWork.DbTransaction).ToList();
        }
    }
}
