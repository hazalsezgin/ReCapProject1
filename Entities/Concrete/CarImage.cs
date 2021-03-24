using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CarImage :IEntity
    {
        [Key] //bu key niye yazılıyor pek bir fikrim yok fakattt Id yi temsil ediyo olabilir NEDEN DİĞERİNİ SEÇMEDİN çünkü oradan geliyor key diğeri farklı bizim yüklediğimiz pakat o castle dı herhalde
        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }
    }
}
