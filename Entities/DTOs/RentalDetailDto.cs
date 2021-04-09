using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto
    {
        public int RentalId { get; set; }
        public string CustomerName { get; set; }
        public int CarId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string ColorName { get; set; }
        public string Descriptions { get; set; }
        public string Email { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
