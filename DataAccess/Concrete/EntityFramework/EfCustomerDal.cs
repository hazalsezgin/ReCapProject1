using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentCarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from u in context.Users
                             join c in context.Customers
                             on u.Id equals c.UserId
                             select new CustomerDetailDto { CustomerId = c.CustomerId, CustomerName = c.CustomerName, FirstName = u.FirstName, LastName = u.LastName, Email = u.Email, UserId = u.Id };
                return result.ToList();

            }
        }
    }
}
