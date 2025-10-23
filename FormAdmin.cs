using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мальев Никита Иванович");
        }
    }
}
