using EP.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SERVICE.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        Customer GetCustomer(int Id);
    }
}
