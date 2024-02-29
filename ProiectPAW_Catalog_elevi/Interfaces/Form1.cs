using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectPAW_Catalog_elevi.DataBase;
using ProiectPAW_Catalog_elevi.Entities;
using ProiectPAW_Catalog_elevi.Repository;

namespace ProiectPAW_Catalog_elevi
{
    public partial class Form1 : Form
    {
        private IStudentUserRepository _studentUserRepository;
        public Form1()
        {
            InitializeComponent();
            _studentUserRepository = new StudentUserRepository();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var userName = textBoxUser.Text;
            var password = textBoxPassword.Text;
            if (_studentUserRepository.GetByPas_UserName(password,userName)==null)
            {
                MessageBox.Show("Parola sau UserName incorect");
            }
            else
            {
                var studentUser = _studentUserRepository.GetByPas_UserName(password, userName);
                Guid id = studentUser.Id;
                var studentForm = new StudentForm(id);
                Hide();
                studentForm.ShowDialog();
            
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Colegiul.Cuza.Alexandria.ro/");
        }

  
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonOK_Click(sender, null);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
