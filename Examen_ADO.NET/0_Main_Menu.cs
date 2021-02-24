using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_ADO.NET
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void readLogsBTN_Click(object sender, EventArgs e)
        {
            Read_Logs readRecord = new Read_Logs();
            readRecord.Show();
        }

        private void comboDataGridBTN_Click(object sender, EventArgs e)
        {
            Combo_DataGrid comboDataGrid = new Combo_DataGrid();
            comboDataGrid.Show();
        }

        private void deleteLogsBTN_Click(object sender, EventArgs e)
        {
            Delete_Logs deleteLogs = new Delete_Logs();
            deleteLogs.Show();
        }

        private void relationDataGridBTN_Click(object sender, EventArgs e)
        {
            DataGrid_Relation relationDataGrid = new DataGrid_Relation();
            relationDataGrid.Show();
        }

        private void executePyFBTN_Click(object sender, EventArgs e)
        {
            Execute_PyF executePandF = new Execute_PyF();
            executePandF.Show();
        }
    }
}
