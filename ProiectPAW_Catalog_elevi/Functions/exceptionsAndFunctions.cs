using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Catalog_elevi.Functions
{
    public static class exceptionsAndFunctions
    {
        public static DataGridView RefreshDataGridView<T>(this DataGridView dataGrid, List<T> data)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = data;
            return dataGrid;
        }
        
        public static DataGridView AddColums(this DataGridView dataGrid, int index, string headerName, string propertyName)
        {
            dataGrid.ColumnCount++;
            dataGrid.Columns[index].HeaderText = headerName;
            dataGrid.Columns[index].DataPropertyName = propertyName;
            return dataGrid;
        }

        public static DataGridView AddButtonColumn(this DataGridView dataGrid, string name, string buttonText, string headerText)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = name;
            buttonColumn.Text = buttonText;
            buttonColumn.HeaderText = headerText;
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGrid.Columns.Add(buttonColumn);
            return dataGrid;
        }
    }
}
