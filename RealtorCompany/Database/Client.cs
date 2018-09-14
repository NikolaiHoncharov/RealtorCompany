using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorCompany.Database
{
    public class Client
    {
        public Client() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Phone { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
