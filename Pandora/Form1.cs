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
        //проверку на количество бонусов

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

        private void tbBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void mtbSearchPhone_KeyUp(object sender, KeyEventArgs e)
        {
            if (mtbSearchPhone.MaskCompleted)
            {
                btnPay.Enabled = true;
                tbFam.Enabled = true;
                tbName.Enabled = true;
                tbOtch.Enabled = true;
                tbPriceGame.Enabled = true;
                tbBonus.Enabled = true;
                bool b = false;
                string[] clientsArray = File.ReadAllLines("clients.csv", Encoding.GetEncoding(1251));
                if(clientsArray.Length > 0)
                {
                    foreach(string str in clientsArray)
                    {
                        btnPay.Text = "Идет поиск...";
                        string[] client = str.Split(';');
                        if(client[3] == mtbSearchPhone.Text)
                        {
                            tbName.Text = client[1];
                            tbFam.Text = client[0];
                            tbOtch.Text = client[2];
                            lblBonus.Text = client[4];
                            b = true;
                            btnPay.Text = "Рассчитать";
                        }
                    }
                }
                if (!b)
                {
                    btnPay.Text = "Сохранить и расчитать";
                }
            }
            else
            {
                tbFam.Clear();
                tbName.Clear();
                tbOtch.Clear();
                btnPay.Enabled = false;
                tbFam.Enabled = false;
                tbName.Enabled = false;
                tbOtch.Enabled = false;
                tbPriceGame.Enabled = false;
                tbBonus.Enabled = false;
                lblBonus.Text = "0";
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

        private void tbPriceGame_TextChanged(object sender, EventArgs e)
        {
            if(tbPriceGame.Text != "")
            {
                int price = Convert.ToInt32(tbPriceGame.Text);
                int bonus = Convert.ToInt32(tbBonus.Text);
                int payment = price - bonus;
                lblPayment.Text = payment.ToString();
            }
            else
            {
                lblPayment.Text = "0";
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string[] clientsArray = File.ReadAllLines("clients.csv", Encoding.GetEncoding(1251));
            if (clientsArray.Length > 0)
            {
                for(int i = 0; clientsArray.Length > i; i++)
                {
                    string[] client = clientsArray[i].Split(';');
                    if (client[3] == mtbSearchPhone.Text)
                    {
                        int bonus = Convert.ToInt32(lblBonus.Text) - Convert.ToInt32(tbBonus.Text);
                        string newClient = tbFam.Text + ";" + tbName.Text + ";" + tbOtch.Text + ";" + mtbSearchPhone.Text + ";" + bonus;
                        clientsArray[i] = newClient;
                        File.WriteAllLines("clients.csv", clientsArray, Encoding.GetEncoding(1251));
                    }
                }
            }
            if(btnPay.Text == "Сохранить и расчитать")
            {
                StreamWriter sw = new StreamWriter("clients.csv", true, Encoding.GetEncoding(1251));
                sw.WriteLine(tbFam.Text + ";" + tbName.Text + ";" + tbOtch.Text + ";" + mtbSearchPhone.Text + ";" + 0);
                sw.Close();
            }
        }
    }
}
