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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form MainForm = Application.OpenForms[0];
            MainForm.Show();
            this.Close();
        }

        private void View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_27ip213DataSet3.ClientService". При необходимости она может быть перемещена или удалена.
            this.clientServiceTableAdapter.Fill(this.school_27ip213DataSet3.ClientService);

        }
    }
}
