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
using RealtorCompany.Control;

namespace RealtorCompany.Forms
{
    public partial class ControlCatalog : UserControl
    {
        byte[] bt { get; set; }
        int indexbttn1 = -1, indexbttn2 = -1, indexbttn3 = -1, indexbttn4 = -1;
        static int i = 0, y = 0;
        List<Database.Apartment> apartment;
        private static ControlCatalog _inctance;
        public static ControlCatalog Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlCatalog();
                return _inctance;
            }
        }
        public ControlCatalog()
        {
            InitializeComponent();
        }

        private void ControlCatalog_Load(object sender, EventArgs e)
        {
            apartment = DBWork.Instance.GetApartment();
            if (apartment != null)
            {
                try
                {
                    for (; i < 4; i++)
                    {
                        if (i == 0) { if (apartment[i] != null || apartment.Count != i && apartment.Count > i) { panel1.Visible = true; Init(lblTitle1, lblAge1, lblTheme1, lblAuthor1, lblPrice1, pchrBxBook1, apartment[i]); indexbttn1 = i; } else break; }
                        if (i == 1) { if (apartment[i] != null || apartment.Count != i && apartment.Count > i) { panel2.Visible = true; Init(lblTitle2, lblAge2, lblTheme2, lblAuthor2, lblPrice2, pchrBxBook2, apartment[i]); indexbttn2 = i; } else break; }
                        if (i == 2) { if (apartment[i] != null || apartment.Count != i && apartment.Count > i) { panel3.Visible = true; Init(lblTitle3, lblAge3, lblTheme3, lblAuthor3, lblPrice3, pchrBxBook3, apartment[i]); indexbttn3 = i; } else break; }
                        if (i == 3) { if (apartment[i] != null || apartment.Count != i && apartment.Count > i) { panel4.Visible = true; Init(lblTitle4, lblAge4, lblTheme4, lblAuthor4, lblPrice4, pchrBxBook4, apartment[i]); indexbttn4 = i; } else break; }

                    }
                }
                catch { }
            }
        }

        private void bnntSale4_Click(object sender, EventArgs e)
        { SaleBook(indexbttn4); }

        private void bnntSale2_Click(object sender, EventArgs e)
        { SaleBook(indexbttn2); }

        private void bnntSale3_Click(object sender, EventArgs e)
        { SaleBook(indexbttn3); }


        private void bnntSale1_Click(object sender, EventArgs e)
        { SaleBook(indexbttn1); }


        //метод вызова контролелра ПРОДАЖИ
        private void SaleBook(int index)
        {
            if (index != -1)
            {
                ControlSale sl = new ControlSale(apartment[index]);

                if (!this.Controls.Contains(sl))
                {
                    this.Controls.Add(sl);
                    sl.Dock = DockStyle.Fill;
                    sl.BringToFront();
                }
                else sl.BringToFront();
            }
        }
        //изменение цены переходит на label
        private void trackBarPrice_Scroll(object sender, EventArgs e)
        {
            lblMin.Text = trackBarPrice.Value.ToString();
        }




        //Загрузка данных в панели
        public void Init(Label lblTitle, Label lblAge, Label lblTheme, Label lblAuthor, Label lblPrice, PictureBox pctrBx, Database.Apartment ap)
        {

            lblPrice.Text = ap.Price + "₴ ";
            lblTitle.Text = ap.Address;
            lblAuthor.Text = "Этаж: " + ap.Floor.ToString();
            lblTheme.Text = "S: "+ ap.Area.ToString();
            lblAge.Text = "Кол комнт:" + ap.CountRoom.ToString();
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

                    //Отличная кв в центре г. Киева
                }
            }
        }

    }
}
