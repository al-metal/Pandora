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
    public partial class Form1 : Form
    {
        NewClient newClient = new NewClient();
        BindingSource binding1 = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            FileInfo file = new FileInfo("clients.csv");
            if(!file.Exists)
            {
                FileStream fs = file.Create();
                fs.Close();
            }
        }

        private void новыйКлиентToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newClient.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] clientsArray = File.ReadAllLines("clients.csv", Encoding.GetEncoding(1251));
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа разработана для\nЛазертаг-Арена \"Пандора\" Ижевск \nтел: 47-00-93\nРазработчик: al-metal@bk.ru", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void tbBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void mtbSearchPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (mtbSearchPhone.MaskCompleted)
            {
                string[] clientsArray = File.ReadAllLines("clients.csv", Encoding.GetEncoding(1251));
                if(clientsArray.Length > 0)
                {
                    foreach(string str in clientsArray)
                    {
                        string[] client = str.Split(';');
                        if(client[3] == mtbSearchPhone.Text)
                        {
                            tbName.Text = client[1];
                            tbFam.Text = client[0];
                            tbOtch.Text = client[2];
                            lblBonus.Text = client[4];
                        }
                    }
                }
            }
        }

        private void tbPriceGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void lblBonus_TextChanged(object sender, EventArgs e)
        {
            tbBonus.Text = lblBonus.Text;
        }

        private void tbBonus_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
