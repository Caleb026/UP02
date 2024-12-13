using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
            this.Close();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_27ip213DataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_27ip213DataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_27ip213DataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.school_27ip213DataSet1.Client);

        }
        public int TimeInSeconds(int a, int b)
        {
            return a * 3600 + b * 60;
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            ch = Convert.ToInt32(textBox1.Text);
            min = Convert.ToInt32(textBox3.Text);
            sec = TimeInSeconds(ch, min);
            int dur = Convert.ToInt32(textBox2.Text);
            sec = sec + dur;
            textBox4.Text = Convert.ToString((int)sec / 3600);
            sec = sec % 3600;
            textBox5.Text = Convert.ToString((int)sec / 60);
        }
    }
}
