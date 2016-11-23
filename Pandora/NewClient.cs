using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pandora
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            if(!mtbPhone.MaskCompleted)
            {
                MessageBox.Show("Поле \"Телефон\" обязательно для заполнения", "Ошибка");
                return;
            }

            bool b = false;
            string[] clientsArray = File.ReadAllLines("clients.csv", Encoding.GetEncoding(1251));
            foreach(string str in clientsArray)
            {
                string[] client = str.Split(';');
                string phone = client[3];
                if (phone == mtbPhone.Text)
                {
                    b = true;
                    break;
                }
            }

            if (b)
            {
                MessageBox.Show("Данный номер уже имеется в программе", "Внимание!");
                return;
            }

            StreamWriter sw = new StreamWriter("clients.csv", true, Encoding.GetEncoding(1251));
            sw.WriteLine(tbFam.Text + ";" + tbName.Text + ";" + tbOtch.Text + ";" + mtbPhone.Text + ";" + 0);
            sw.Close();

            tbName.Clear();
            tbFam.Clear();
            tbOtch.Clear();
            mtbPhone.Clear();

            this.Close();
        }
    }
}
