using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var rentalReturnDate = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            if (rentalReturnDate.Count > 0)
            {
                foreach (var result in rentalReturnDate) 
                {
                    if (result.ReturnDate == null) 
                    {
                        return new ErrorResult("teslim edilmemiş araba var");
                    }
                }
            }


            _rentalDal.Add(rental);
            return new SuccessResult("kiralama işlemi başarılı");
            
        }

        public IResult Delete(Rental rental)
        {

            _rentalDal.Delete(rental);
            return new SuccessResult("kiralama işlemi silindi");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            //iş kodları
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetByRentalId(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
           return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult("kiralama işlemi güncellendi");
        }
    }
}
