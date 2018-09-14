using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorCompany.Database
{
    public class Booking
    {
        public Booking() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public Client Client { get; set; }

    }
}
