using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace RealtorCompany
{
    public partial class FrmLogin : Form
    {
        FrmMain frmMain;
        public FrmLogin(FrmMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }

        private void bttnExit1_Click(object sender, EventArgs e){Close();}

        private void bttnEnter_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (!String.IsNullOrWhiteSpace(txtEmailEnter.Text) && !String.IsNullOrWhiteSpace(txtPassword.Text))
            {
               List<Employee> Employee = DBWork.Instance.GetEmployee();
                for (int i = 0; i < Employee.Count; i++)
                {
                    if ((Employee[i].Email == txtEmailEnter.Text) && (Employee[i].Password == txtPassword.Text))
                    {
                        flag = true;
                        frmMain.empl = Employee[i];
                        Close();
                    }
                }
                if (flag == false) MessageBox.Show("Заполните поля");
                    txtEmailEnter.Text = "Email";
                    txtPassword.Text = "Пароль";
            }

            if (String.IsNullOrWhiteSpace(txtEmailEnter.Text)) { txtEmailEnter.BackColor = Color.Red; txtEmailEnter.Text = "Введите email"; }
            if (String.IsNullOrWhiteSpace(txtPassword.Text)) { txtPassword.BackColor = Color.Red; txtPassword.Text = "Введите пароль"; }

        }

        private void bttnRegistrPnl_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void bttnSingUp_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(txtFName.Text) && !String.IsNullOrWhiteSpace(txtEmail.Text) && !String.IsNullOrWhiteSpace(txtSName.Text))&&
                (txtFName.Text != "Имя" && txtEmail.Text != "Email" && txtSName.Text != "Фамилия"))
            { 
                if (PositionAd.Checked)
                    DBWork.Instance.AddEmployee(txtFName.Text, txtSName.Text, txtEmail.Text, SendEmail().ToString(), "Администратор");

                if (PositionRl.Checked)
                    DBWork.Instance.AddEmployee(txtFName.Text, txtSName.Text, txtEmail.Text, SendEmail().ToString(), "Риэлтор");
            }
            else MessageBox.Show("Заполните все поля", "Внимание!");
        }

        //Отправка пароля на почту
        private int SendEmail()
        {
            Random rnd = new Random();
            int password = rnd.Next(100000, 999999);
            MailAddress fromMAilAddress = new MailAddress("Enter Email ....@gmail.com", "Realtor Company");
            MailAddress toAddress = new MailAddress(txtEmail.Text, txtFName.Text + " " + txtSName.Text);

            using (MailMessage mailMessage = new MailMessage(fromMAilAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                mailMessage.Subject = "Подтверждение регистрации";
                mailMessage.Body = "Добрый день, " + txtFName.Text + "! Ваш пароль: " + password;

                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMAilAddress.Address, "Enter Password E-mail");

                smtpClient.Send(mailMessage);
                return password;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }


        ///РАБОТА С тектсом EMAIl при входе
        //нажал на текст 
        private void txtEmailEnter_Click(object sender, EventArgs e)
        {
            if (txtEmailEnter.Text == "Email")
            {
                lblEmail.Visible = true;
                txtEmailEnter.Text = "";
            }
        }

        //нажал на другую кнопку 
        private void txtEmailEnter_Leave(object sender, EventArgs e)
        {
            if (txtEmailEnter.Text == "")
            {
                lblEmail.Visible = false;
                txtEmailEnter.Text = "Email";
            }
        }


        ///РАБОТА С тектсом PASSWORD при входе
        //нажал на текст пароля
        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Пароль")
            {
                lblPassword.Visible = true;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                lblPassword.Visible = false;
                txtPassword.Text = "Пароль";
            }
        }
    }
}
