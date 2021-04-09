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
                var carImages = from cImages in contex.CarImages
                                select cImages;

                var result = from c in contex.Cars
                             join b in contex.Brands
                             on c.BrandId equals b.BrandId
                             join o in contex.Colors
                             on c.ColorId equals o.ColorId
                             
                             
                             select new CarDetailDto { CarId = c.Id, BrandName = b.BrandName, ColorName = o.ColorName, Description = c.Description, ModelYear=c.ModelYear, DailyPrice=c.DailyPrice,ImagePath=c.ImagePath
                            
                             };
                return result.ToList();
            }
                
        }
        public CarDetailDto GetCarDetail(int carId)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from car in context.Cars.Where(c => c.Id == carId)

                             join color in context.Colors
                             on car.ColorId equals color.ColorId

                             join brand in context.Brands
                             on car.BrandId equals brand.BrandId

                             select new CarDetailDto()
                             {
                                 BrandId = brand.BrandId,
                                 ColorId = color.ColorId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear,
                                 CarId = car.Id,
                                 ImagePath=car.ImagePath
                                 //MinFindexScore = car.MinFindexScore
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
