using EP.DAL;
using EP.DAL.Models;
using EP.DAL.Repositories.Interfaces;
using EP.SERVICE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.SERVICE
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _customerRepository = _unitOfWork.GetRegisteredRepository<ICustomerRepository>();
        }

        public Customer GetCustomer(int Id)
        {
            using (_unitOfWork)
            {
                return _customerRepository.GetCustomer(Id);
            }
        }

        public List<Customer> GetCustomers()
        {
            using (_unitOfWork)
            {
                return _customerRepository.GetCustomers();
            }
        }
    }
}
