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

namespace RealtorCompany.Control
{
    public partial class ControlAddApart : UserControl
    {
        byte[] bt { get; set; }
        private static ControlAddApart _inctance;
        public static ControlAddApart Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlAddApart();
                return _inctance;
            }
        }
        public ControlAddApart()
        {
            InitializeComponent();
        }

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
                                    int indexApart = DBWork.Instance.AddApartment(tbTitle.Text, area, countRm, floor, number, price, tbAddress.Text);
                                    if (indexApart != 0 && bt!=null)
                                        DBWork.Instance.AddPicture(indexApart, bt);
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
    }
}
