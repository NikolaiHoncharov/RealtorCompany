using RealtorCompany.Control;
using RealtorCompany.Database;
using RealtorCompany.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtorCompany
{
    public partial class FrmMain : Form
    {
       public Employee empl { get; set; }
        public FrmMain(){InitializeComponent();}

        //Загркзка формы
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Opacity = .75;
            this.Enabled = false;
            FrmLogin lg = new FrmLogin(this);
            lg.ShowDialog();
            //закрытие формы если не передали значение
            if(( lg == null || !lg.IsDisposed) && (empl == null)) Close();
            if (lg == null || !lg.IsDisposed)
            {
                this.Opacity = 1;
                Enabled = true;
                lblFIO.Text = empl.FirstName + " " + empl.SecondName;
                if (empl.Position == "Администратор")
                {
                    bttnChange.Visible = true;
                    bttnAdd.Visible = true;
                }
                if (!pnlMain.Controls.Contains(ControlMain.Instance))
                {
                    pnlMain.Controls.Add(ControlMain.Instance);
                    ControlMain.Instance.Dock = DockStyle.Fill;
                    ControlMain.Instance.BringToFront();
                }
                else ControlMain.Instance.BringToFront();
            }
        }

        //кнопка закрытие формы 
        private void bttnExit_Click(object sender, EventArgs e){Close();}

        //кнопка закрытия и открытия меню
        private void bttnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 237) pnlMenu.Width = 43;
            else pnlMenu.Width = 237;
        }

        //Кнопка вызова изменения профиля работника
        private void bttnChangeProfile_Click(object sender, EventArgs e)
        {
            ControlChangeEmployee controlChangeEmployee = new ControlChangeEmployee(empl);
           
            pnlMain.Controls.Add(controlChangeEmployee);
            controlChangeEmployee.Dock = DockStyle.Fill;
            controlChangeEmployee.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ControlMain.Instance))
            {
                pnlMain.Controls.Add(ControlMain.Instance);
                ControlMain.Instance.Dock = DockStyle.Fill;
                ControlMain.Instance.BringToFront();
            }
            else ControlMain.Instance.BringToFront();
        }

        private void bttnCatalog_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ControlCatalog.Instance))
            {
                pnlMain.Controls.Add(ControlCatalog.Instance);
                ControlCatalog.Instance.Dock = DockStyle.Fill;
                ControlCatalog.Instance.BringToFront();
            }
            else ControlCatalog.Instance.BringToFront();
        }

        private void bttnBooking_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ControlBooking.Instance))
            {
                pnlMain.Controls.Add(ControlBooking.Instance);
                ControlBooking.Instance.Dock = DockStyle.Fill;
                ControlBooking.Instance.BringToFront();
            }
            else ControlBooking.Instance.BringToFront();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ControlAddApart.Instance))
            {
                pnlMain.Controls.Add(ControlAddApart.Instance);
                ControlAddApart.Instance.Dock = DockStyle.Fill;
                ControlAddApart.Instance.BringToFront();
            }
            else ControlAddApart.Instance.BringToFront();
        }

        private void bttnChange_Click(object sender, EventArgs e)
        {
            if (!pnlMain.Controls.Contains(ControlChangeApart.Instance))
            {
                pnlMain.Controls.Add(ControlChangeApart.Instance);
                ControlChangeApart.Instance.Dock = DockStyle.Fill;
                ControlChangeApart.Instance.BringToFront();
            }
            else ControlChangeApart.Instance.BringToFront();
        }

        private void bttnStatistic_Click(object sender, EventArgs e)
        {
              if (!pnlMain.Controls.Contains(ControlStatistic.Instance))
            {
                pnlMain.Controls.Add(ControlStatistic.Instance);
                ControlStatistic.Instance.Dock = DockStyle.Fill;
                ControlStatistic.Instance.BringToFront();
            }
            else ControlStatistic.Instance.BringToFront();
        }
    }
}
