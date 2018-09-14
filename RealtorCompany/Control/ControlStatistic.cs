using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealtorCompany.Database;

namespace RealtorCompany.Control
{
    public partial class ControlStatistic : UserControl
    {

        private static ControlStatistic _inctance;
        public static ControlStatistic Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlStatistic();
                return _inctance;
            }
        }
        public ControlStatistic()
        {

            InitializeComponent();
            using (RealtorContext db = new RealtorContext())
            {
               var query = (from pr in db.Purchases
                        group pr by pr.DatePurchase.Month into s
                        select new {Date = s.Key, Count = s.Count() }).ToList();
                //charStatistic.Series["Salary"].XValueMember = "Date";
                //charStatistic.Series["Salary"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
                //charStatistic.Series["Salary"].YValueMembers = "Count";
                //charStatistic.Series["Salary"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                charStatistic.DataSource = query;
                foreach (var item in query)
                {
                    charStatistic.Series["Salary"].Points.AddXY(query.Count,1);
                }

            }
            
        }
    }
}
