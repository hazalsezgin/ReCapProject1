using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{ //NuGet
    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarContext contex = new RentCarContext()) 
            {
                var result = from c in contex.Cars
                             join b in contex.Brands
                             on c.BrandId equals b.BrandId
                             join o in contex.Colors
                             on c.ColorId equals o.ColorId
                             select new CarDetailDto { CarId = c.Id, BrandName = b.BrandName, ColorName = o.ColorName, Description = c.Description
                             };
                return result.ToList();
            }
                
        }
    }
}
