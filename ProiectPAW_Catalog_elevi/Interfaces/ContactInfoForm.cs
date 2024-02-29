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


namespace ProiectPAW_Catalog_elevi
{
    public partial class ContactInfoForm : Form
    {
        private IStudentRepository _studentRepository;
        private Guid _id;
        public ContactInfoForm(Guid id)
        {
            MaximizeBox = false;
            InitializeComponent();
            _studentRepository = new StudentRepository();
            textBoxAdresa.Text = _studentRepository.getById(id).Adresa;
            textBoxEmail.Text = _studentRepository.getById(id).emailPersonal;
            textBoxTelefon.Text = _studentRepository.getById(id).NrTelefonTutore;
            _id = id;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var info = _studentRepository.getById(_id);

            info.Adresa = textBoxAdresa.Text;
            info.emailPersonal = textBoxEmail.Text;
            var tel = textBoxTelefon.Text;
            if (tel.Length > 10)
            MessageBox.Show("Numarul de telefon trebuie sa contina 10 caractere.");
            else
            { info.NrTelefonTutore = textBoxTelefon.Text; Hide(); }
           
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ContactInfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
