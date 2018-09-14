using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorCompany.Database
{
    public class Apartment
    {
        public Apartment() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Area { get; set; }
        public int CountRoom { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public string Address { get; set; }

        public ICollection<Picture> Pictures { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
