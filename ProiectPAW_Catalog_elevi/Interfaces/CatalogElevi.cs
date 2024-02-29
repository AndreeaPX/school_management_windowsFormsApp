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
using ProiectPAW_Catalog_elevi.Repository;
using ProiectPAW_Catalog_elevi.Functions;
using ProiectPAW_Catalog_elevi.Entities;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProiectPAW_Catalog_elevi
{

    public partial class CatalogElevi : Form
    {
        private IProfRepository _profRepository;
        private Guid _UserId;
        private Guid _IdClasa;

        public CatalogElevi(Guid id, Guid clasa)
        {
            InitializeComponent();
            _profRepository = new ProfRepository();
            tbvc.Text = StudentsDataBase.classes.FirstOrDefault(x => x.Id == clasa).Name;
            labelProf.Text = _profRepository.getById(id).ToString();
            labelDisciplina.Text = _profRepository.getMaterie(id);
            dataGridView1.AutoGenerateColumns = false;
       
            dataGridView1.AddColums(0, "Elev", "Nume_elev")
                .AddColums(1, "Nota", "Value")
                .AddColums(2, "Absenta", "Absenta")
                .AddColums(3, "Data", "data");
            dataGridView1.DataSource = _profRepository.getSubjectAndGradeForCatalog(id, clasa).OrderBy(x => x.Nume_elev).ToList();
            _UserId = id;
            _IdClasa = clasa;

            dataGridView1.AddButtonColumn("Update", "Update", string.Empty)
               .AddButtonColumn("Delete", "Delete", string.Empty);
           // dataGridView1.CellClick += dataGridView1_CellClick;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CatalogElevi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var add = new FormAddGrade(_IdClasa, _UserId);
            var result=add.ShowDialog();
          
            var data = _profRepository.getSubjectAndGradeForCatalog(_UserId, _IdClasa).OrderBy(x => x.Nume_elev).ToList();
            dataGridView1.RefreshDataGridView(data);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                ObjectSubject currentObject = (ObjectSubject)dataGridView1.CurrentRow.DataBoundItem;

                Grade actual = StudentsDataBase.grades.FirstOrDefault(x => x.Id == currentObject.Id);

                _profRepository.getSubjectAndGradeForCatalog(_UserId, _IdClasa).Remove(currentObject);
                StudentsDataBase.grades.Remove(actual);
                var data = _profRepository.getSubjectAndGradeForCatalog(_UserId, _IdClasa).OrderBy(x => x.Nume_elev).ToList();
                dataGridView1.RefreshDataGridView(data);
            }

            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
            {
                ObjectSubject currentObject = (ObjectSubject)dataGridView1.CurrentRow.DataBoundItem;
                var editForm = new EditForm(currentObject.Id,_IdClasa,_UserId);
                editForm.ShowDialog();
                var data = _profRepository.getSubjectAndGradeForCatalog(_UserId, _IdClasa).OrderBy(x => x.Nume_elev).ToList();
                dataGridView1.RefreshDataGridView(data);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

     

    }
}
