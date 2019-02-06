using EP.SERVICE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EP.WEB.API.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("api/customer/{Id}")]
        public IHttpActionResult GetCustomer(int Id)
        {
           
            //Check if survey is created for the workflow then return existing survey else return template survey.
            return Ok(_customerService.GetCustomer(Id));
        }

        [HttpGet]
        [Route("api/customer/")]
        public IHttpActionResult GetCustomers()
        {

            //Check if survey is created for the workflow then return existing survey else return template survey.
            return Ok(_customerService.GetCustomers());
        }
    }
}
