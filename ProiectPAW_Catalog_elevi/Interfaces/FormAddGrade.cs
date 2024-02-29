using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectPAW_Catalog_elevi.Repository;
using ProiectPAW_Catalog_elevi.Entities;
using ProiectPAW_Catalog_elevi.DataBase;

namespace ProiectPAW_Catalog_elevi
{
   
    public partial class FormAddGrade : Form
    {
        private IProfRepository _profRepository;
        private Guid _idClass;
        private Guid _id_prof;
        public FormAddGrade(Guid id_clasa, Guid id_prof)
        {
            InitializeComponent();
            _profRepository = new ProfRepository();
            comboBox1.DataSource = _profRepository.getStudForClass(id_clasa);

            _id_prof = id_prof;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var nota = new Grade();
            nota.Absenta = checkBox1.Checked;
            nota.data = DateTime.Now;
            if(textBox1.Text=="")
            {
                nota.Value = 0;
            }
            else
            {
                nota.Value = Int32.Parse(textBox1.Text);
            }
            nota.Id = Guid.NewGuid();
            var stud = (string)comboBox1.SelectedItem;
            nota.StudentId = StudentsDataBase.students.FirstOrDefault(x => x.Nume == stud).UserId;
            string materie= _profRepository.getMaterie(_id_prof);
            nota.SubjectId = StudentsDataBase.subjects.FirstOrDefault(x => x.Denumire == materie).Id;

           

            if(nota.Absenta==true && nota.Value!=0)
            {
                MessageBox.Show("Nu puteti selecta ambele absenta ori nota in acelasi timp, va rugam sa reincercati");
            }
            else
            if(nota.Value<0 || nota.Value>10)
            {
                MessageBox.Show("Nota invalida");
            } 
            else
            StudentsDataBase.grades.Add(nota);
            DialogResult = DialogResult.OK;
           
        }

        private void FormAddGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
