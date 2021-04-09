using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public Decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } 

    }
}
