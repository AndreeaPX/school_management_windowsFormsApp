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
using ProiectPAW_Catalog_elevi.DataBase;
using ProiectPAW_Catalog_elevi.Repository;
using ProiectPAW_Catalog_elevi.Functions;

namespace ProiectPAW_Catalog_elevi
{
    public partial class StudentForm : Form
    {
        private IStudentRepository _studentRepository;

        private Guid _userId;
        public StudentForm(Guid id)
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
   
            StudentGridView.AutoGenerateColumns = false;
            StudentGridView.ReadOnly = true;  
            StudentGridView.AllowUserToAddRows = false;
            StudentGridView.AddColums(0, "Nume", "Nume")
                
                .AddColums(1, "Gen", "gen")
                .AddColums(2, "CNP", "CNP");
            StudentGridView.DataSource = _studentRepository.getStudentForUser(id);
            StudentGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            label3.Text = _studentRepository.getById(id).ToString();
            labelClass.Text = _studentRepository.getClass(id);
            dataGridViewNote.AutoGenerateColumns = false;
            dataGridViewNote.ReadOnly = true;
            dataGridViewNote.AllowUserToAddRows = false;
            dataGridViewNote.AddColums(0, "Materie", "Denumire")
                .AddColums(1, "Nota", "Value")
                .AddColums(2, "Absent", "Absenta")
                .AddColums(3, "Data", "data");
            dataGridViewNote.DataSource = _studentRepository.getSubjectAndGradeForStudent(id).OrderBy(x=>x.Denumire).ToList();
            _userId = id;
            label6.Text = "";
        }

        private void buttonDetaliiContact_Click(object sender, EventArgs e)
        {
            var contactInfoForm = new ContactInfoForm(_userId);
            contactInfoForm.ShowDialog();
        }

        private void dataGridViewNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView obgv = sender as DataGridView;
                tbvc.Text = obgv[e.ColumnIndex, e.RowIndex].Value as string;
                var suma_note = _studentRepository.getSubjectAndGradeForStudent(_userId).Where(x => x.Denumire == tbvc.Text).Sum(x => x.Value);
                var nr_note = _studentRepository.getSubjectAndGradeForStudent(_userId).Where(x => x.Denumire == tbvc.Text && x.Absenta==false).Count();
                var medie = suma_note / nr_note;
                textBoxMedie.Text = medie.ToString();

                int nr_absente = _studentRepository.getSubjectAndGradeForStudent(_userId).Where(x => x.Denumire == tbvc.Text && x.Absenta == true).Count();
                if (nr_absente != 0)
                {
                    label6.Text = nr_absente.ToString();
                }
                else
                    label6.Text = "Nu exista absente.";
                
            }
            catch { }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
