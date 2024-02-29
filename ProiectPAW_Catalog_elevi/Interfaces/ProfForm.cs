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
using System.IO;

using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProiectPAW_Catalog_elevi
{
    public partial class ProfForm : Form
    {
        private IProfRepository _profRepository;
        private Guid _UserId;
        private Guid _clasa;
        public ProfForm(Guid id)
        {
            InitializeComponent();
            _profRepository = new ProfRepository();
            dataGridViewProf.AutoGenerateColumns = false;
            dataGridViewProf.ReadOnly = true;
            dataGridViewProf.AllowUserToAddRows = false;
            dataGridViewProf.AddColums(0, "Nume", "Name")
                .AddColums(1, "Salariu", "Salariu");
            dataGridViewProf.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProf.DataSource = _profRepository.getTeacherForUser(id);
            dataGridViewClase.AutoGenerateColumns = false;
            dataGridViewClase.ReadOnly = true;
            dataGridViewClase.AllowUserToAddRows = false;
            dataGridViewClase.AddColums(0, "Clasa", "Name");
            dataGridViewClase.DataSource = _profRepository.GetClassesForTeacher(id);
            labelMaterie.Text = _profRepository.getMaterie(id);
            _UserId = id;
        }

        private void ProfForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewClase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView obgv = sender as DataGridView;
                tbvc.Text = obgv[e.ColumnIndex, e.RowIndex].Value as string;
                _clasa = StudentsDataBase.classes.FirstOrDefault(x => x.Name == tbvc.Text).Id;
                           }
            catch {
              
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbvc.Text != "")
                {
                    var catalog = new CatalogElevi(_UserId, _clasa);
                    catalog.ShowDialog();
                }
                else
                    MessageBox.Show("selectati o optiune");

            }
            catch(Exception exceptie) {
                MessageBox.Show("selectati o optiune");

            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|*.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    FileStream fileStream =
                        new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, StudentsDataBase.teachers.Where(x=>x.UserId==_UserId).ToList());
                    fileStream.Close();

                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary file|*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    using (FileStream fileStream =
                        new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        StudentsDataBase.teacherData= formatter.Deserialize(fileStream) as List<Teacher>;
                    }
                }
            }
        }
    }
}
