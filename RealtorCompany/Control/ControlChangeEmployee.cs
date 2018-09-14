using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtorCompany
{
    public partial class ControlChangeEmployee : UserControl
    {
        int Index = -1;
        Employee empl;
        List<Employee> Employee;
        public ControlChangeEmployee(Employee empl)
        {
            InitializeComponent();
            this.empl = empl;
            Employee = new List<Employee>();
        }

        //Загрузка формы
        private void ControlChangeEmployee_Load(object sender, EventArgs e)
        {
            if (empl.Position == "Риэлтор")
            {
                ShowEmplInTb(empl);
            }
            else
            {
                ShowEmplInTb(empl);
                lblSecondName2.Visible = true;
                comboBox1.Visible = true;
                gbPosition.Visible = true;
                PositionAd.Visible = true;
                PositionRl.Visible = true;
                Employee = DBWork.Instance.GetEmployee();
                if (Employee != null)
                    foreach (var employee in Employee) comboBox1.Items.Add(employee.SecondName);         
            }
        }

        //измен выбора в комбо бокс
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowEmplInTb(Employee[comboBox1.SelectedIndex]);
        }

        //кнопка сохранить
        private void bttnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbName.Text) && !String.IsNullOrWhiteSpace(tbSecondName.Text) && 
                !String.IsNullOrWhiteSpace(tbPassword.Text) && !String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                if (PositionAd.Checked)
                    DBWork.Instance.ChangeEmployee(tbName.Text, tbSecondName.Text, tbPassword.Text, tbEmail.Text, "Администратор", Index);

                if (PositionRl.Checked)
                    DBWork.Instance.ChangeEmployee(tbName.Text, tbSecondName.Text, tbPassword.Text, tbEmail.Text, "Риэлтор", Index);
            }
            else MessageBox.Show("Заполните все поля", "Внимание!");
        }


        //зпгрузка данных в форму
        private void ShowEmplInTb(Employee empl)
        {
            tbName.Text = empl.FirstName;
            tbSecondName.Text = empl.SecondName;
            tbEmail.Text = empl.Email;
            tbPassword.Text = empl.Password;
            if (empl.Position == "Риэлтор")
            {
                PositionAd.Checked = false;
                PositionRl.Checked = true;
            }
            else
            {
                PositionAd.Checked = true;
                PositionRl.Checked = false;
            }
            Index = empl.Id;
        }

    }
}
