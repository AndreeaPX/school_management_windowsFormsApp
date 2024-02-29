using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectPAW_Catalog_elevi.Entities;
using ProiectPAW_Catalog_elevi.Repository;
using ProiectPAW_Catalog_elevi.DataBase;

namespace ProiectPAW_Catalog_elevi
{
    public partial class FormProfLog : Form
    {
        private IUserProfRepository _profRepository;
        public FormProfLog()
        {
            InitializeComponent();
            _profRepository = new UserProfRepository();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var userName = textBoxUser.Text;
            var password = textBoxPass.Text;
            if (_profRepository.GetUserNamePass(password, userName) == null)
            {
                MessageBox.Show("Parola sau UserName incorect");
            }
            else
            {
                var profUser = _profRepository.GetUserNamePass(password, userName);
                Guid id = profUser.Id;
                var profForm = new ProfForm(id);
                Hide();
                profForm.ShowDialog();

            }
        }

        private void FormProfLog_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonOK_Click(sender, null);
            }
        }
    }
}
