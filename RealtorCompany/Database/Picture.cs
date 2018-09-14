using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtorCompany.Database
{
    public class Picture
    {
        public Picture() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }

    }
}
