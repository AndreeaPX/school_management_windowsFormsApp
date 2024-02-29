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
    public partial class EditForm : Form
    {
        private IProfRepository _profRepository;
        private Guid _idClass;
        private Guid _id_notaOS;
        private Guid _id_prof;
        public EditForm(Guid idObCurent, Guid id_clasa, Guid id_prof)
        {
            InitializeComponent();
            _profRepository = new ProfRepository();
            var entities = _profRepository.getSubjectAndGradeForCatalog(id_prof, id_clasa);
            var entity = entities.FirstOrDefault(x => x.Id == idObCurent);
            labelNume.Text = entity.Nume_elev;
            textBoxNota.Text = entity.Value.ToString();
            checkBox1.Checked = entity.Absenta;
            _idClass = id_clasa;
            _id_notaOS = idObCurent;
            _id_prof = id_prof;
            
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var entities = _profRepository.getSubjectAndGradeForCatalog(_id_prof, _idClass);
            var nota = entities.FirstOrDefault(x => x.Id == _id_notaOS);
            nota.Value = Int32.Parse(textBoxNota.Text);
            nota.Absenta = checkBox1.Checked;
            if (nota.Value!= 0 && nota.Absenta==true)
            {
                MessageBox.Show("Nu puteti seta si absenta si nota in acelasi timp, va rugam sa selectati una dintre cele doua");
            }
            else
            if(nota.Value<0 || nota.Value>10)
            {
                MessageBox.Show("Nota invalida");
            }
            else
            if((nota.Value!=0 && nota.Absenta==false)||(nota.Value==0 && nota.Absenta==true))
            {
                var notaT = StudentsDataBase.grades.FirstOrDefault(x => x.Id == _id_notaOS);
                notaT.Value = Int32.Parse(textBoxNota.Text);
                notaT.Absenta = checkBox1.Checked;
            }
            Hide();
        }
    }
}
