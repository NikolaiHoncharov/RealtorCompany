using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media.Imaging;

namespace RealtorCompany.Control
{
    public partial class ControlSale : UserControl
    {
        byte[] bt { get; set; }
        Database.Apartment ap;
        public ControlSale(Database.Apartment ap)
        {
            InitializeComponent();
            this.ap = ap;
        }

        //загрузка формы + загрузка данных о книге в контрол
        private void ControlSale_Load(object sender, EventArgs e)
        {
            tbTitle.Text = ap.Title;
            tbAddress.Text = ap.Address;
            tbCountRoom.Text = ap.CountRoom.ToString();
            tbArea.Text = ap.Area.ToString();
            tbFloor.Text = ap.Floor.ToString();
            tbPrice.Text = ap.Price.ToString() + "₴";
            bt = DBWork.Instance.SearchApart(ap.Id);
            if (bt != null)
            {
                using (var ms = new MemoryStream(bt))
                {
                    var bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.StreamSource = ms;
                    bitmapImage.EndInit();
                    using (MemoryStream outStream = new MemoryStream())
                    {
                        BitmapEncoder enc = new BmpBitmapEncoder();
                        enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                        enc.Save(outStream);
                        Bitmap bitmap = new System.Drawing.Bitmap(outStream);

                        pctrBx.Image = bitmap;
                    }
                }
            }
        }

        private void bttnDispose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bttnSale_Click(object sender, EventArgs e)
        {
            DBWork.Instance.SaleApart(ap.Id);
            //освобождение ресурсов закрытие контроллера
            this.Dispose();
        }
    }
}
