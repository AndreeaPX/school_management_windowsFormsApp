using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Catalog_elevi
{
    public partial class FormIntrare : Form
    {
        public FormIntrare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void buttonProfesor_Click(object sender, EventArgs e)
        {
            var formProf = new FormProfLog();
            formProf.ShowDialog();
        }
    }
}
