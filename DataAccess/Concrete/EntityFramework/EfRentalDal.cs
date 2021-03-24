using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             join r in context.Rentals
                             on c.CustomerId equals r.CustomerId
                             join a in context.Cars
                             on r.CarId equals a.Id
                             join b in context.Brands
                             on a.BrandId equals b.BrandId
                             join o in context.Colors
                             on a.ColorId equals o.ColorId
                             select new RentalDetailDto
                             {
                                 RentalId = r.Id,
                                 CustomerName = c.CustomerName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 BrandName = b.BrandName,
                                 CarId = a.Id,
                                 ModelYear = a.ModelYear,
                                 DailyPrice = a.DailyPrice,
                                 ColorName = o.ColorName,
                                 Descriptions = a.Description,
                                 Email = u.Email,
                                 RentDate = r.RentDate

                             };


                return result.ToList();
            }
        }
    }
}
