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
    public partial class ControlChangeApart : UserControl
    {
        int index = -1;
        byte[] bt { get; set; }
        private static ControlChangeApart _inctance;
        public static ControlChangeApart Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlChangeApart();
                return _inctance;
            }
        }
        public ControlChangeApart()
        {
            InitializeComponent();
        }


        //нажатие на кнопку поиска
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbSearch.Text))
            {
                Database.Apartment apartment = DBWork.Instance.SearchApart(tbSearch.Text);
                if (apartment != null)
                {
                    tbTitle.Text = apartment.Title;
                    tbArea.Text = apartment.Area.ToString();
                    tbCountRoom.Text = apartment.CountRoom.ToString();
                    tbFloor.Text = apartment.Floor.ToString();
                    tbNumberApart.Text = apartment.Number.ToString();
                    tbPrice.Text = apartment.Price.ToString();
                    tbAddress.Text = apartment.Address.ToString();
                    index = apartment.Id;
                    bt = DBWork.Instance.SearchApart(apartment.Id);
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

                                pbPictureApartment.Image = bitmap;
                            }

                            //Отличная кв в центре г. Киева
                        }
                    }
                }
                else MessageBox.Show("Нет соответствий!");
            }
        }

        //наж кнопка сохран
        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbTitle.Text) && !String.IsNullOrWhiteSpace(tbArea.Text) && !String.IsNullOrWhiteSpace(tbCountRoom.Text) && !String.IsNullOrWhiteSpace(tbFloor.Text) &&
               !String.IsNullOrWhiteSpace(tbNumberApart.Text) && !String.IsNullOrWhiteSpace(tbPrice.Text) && !String.IsNullOrWhiteSpace(tbAddress.Text))
            {
                int area = 0, countRm = 0, floor = 0, number = 0, price = 0;

                if (int.TryParse(tbArea.Text, out area))
                {
                    if (int.TryParse(tbCountRoom.Text, out countRm))
                    {
                        if (int.TryParse(tbFloor.Text, out floor))
                        {
                            if (int.TryParse(tbNumberApart.Text, out number))
                            {
                                if (int.TryParse(tbPrice.Text, out price))
                                {
                                    if (index !=-1)
                                    {
                                        DBWork.Instance.ChangeApartment(tbTitle.Text, area, countRm, floor, number, price, tbAddress.Text, index);
                                        DBWork.Instance.ChangePicture(index, bt);
                                    }
                                }
                                else MessageBox.Show("только числовые значения");
                            }
                            else MessageBox.Show("только числовые значения");
                        }
                        else MessageBox.Show("только числовые значения");
                    }
                    else MessageBox.Show("только числовые значения");
                }
                else MessageBox.Show("только числовые значения");
            }
            else MessageBox.Show("Заполните все поля!");
        }


        //наж кнопка картинки
        private void bttnPictureSave_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения

            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                    //this.pbPictureApartment.Size = image.Size;
                    pbPictureApartment.Image = image;
                    pbPictureApartment.Invalidate();
                    bt = File.ReadAllBytes(open_dialog.FileName);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
