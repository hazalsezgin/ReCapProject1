using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId); 
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<CarDetailDto> GetCarDetail(int carId);
        IDataResult <Car> GetById(int Id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult AddTransactionalTest(Car car);

    }
    //restful(internet protokolü)-http-
}
