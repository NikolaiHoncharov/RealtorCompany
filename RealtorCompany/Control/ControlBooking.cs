using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtorCompany.Forms
{
    public partial class ControlBooking : UserControl
    {
        private static ControlBooking _inctance;
        public static ControlBooking Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlBooking();
                return _inctance;
            }
        }
        public ControlBooking()
        {
            InitializeComponent();
        }
    }
}
