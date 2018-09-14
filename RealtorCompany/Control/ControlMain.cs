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
using Word = Microsoft.Office.Interop.Word;//для удобства писания мы сократили форму записи 

namespace RealtorCompany
{
    public partial class ControlMain : UserControl
    {

        private static ControlMain _inctance;
        public static ControlMain Instance
        {
            get
            {
                if (_inctance == null)
                    _inctance = new ControlMain();
                return _inctance;
            }
        }
        public ControlMain()
        {
            InitializeComponent();
        }
        //private readonly string TemplateFileName = @"D:\Test.docx";
        private void ControlMain_Load(object sender, EventArgs e)
        {
            try
            {
                axAcroPDF1.src = @"D:\RealtCompany.pdf";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally
            //{
            //    axAcroPDF1.Dispose();
            //}

            //var wordApp = new Word.Application();
            //wordApp.Visible = false;
            //try
            //{
            //    var wordDocument = wordApp.Documents.Open(TemplateFileName);
            //    var renge = wordDocument.Content;
            //    richTextBox1.Text = renge.Text;
            //    //Закрытие документа 
            //    wordDocument.Close();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            //finally
            //{
            //    //завершение приложение работы ВОРДа
            //    wordApp.Quit();
            //}
        }
    }
}
