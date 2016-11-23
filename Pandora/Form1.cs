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
        public Form1()
        {
            InitializeComponent();

        }

        private void новыйКлиентToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newClient.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] clientsArray = File.ReadAllLines("clients.csv", Encoding.GetEncoding(1251));
            foreach(string str in clientsArray)
            {
                dataGridView1.Rows.Add();
            }
            for(int i = 0; clientsArray.Length > i; i++)
            {
                string[] client = clientsArray[i].Split(';');
                dataGridView1.Rows[i].Cells[0].Value = client[3].ToString();
                dataGridView1.Rows[i].Cells[1].Value = client[0].ToString();
                dataGridView1.Rows[i].Cells[2].Value = client[1].ToString();
                dataGridView1.Rows[i].Cells[3].Value = client[2].ToString();
                dataGridView1.Rows[i].Cells[4].Value = client[4].ToString();
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа разработана для\nЛазертаг-Арена \"Пандора\" Ижевск \nтел: 47-00-93\nРазработчик: al-metal@bk.ru", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
