using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_ADO.NET
{
    public partial class Read_Logs : Form
    {
        DataTable dt;

        public Read_Logs()
        {
            InitializeComponent();
        }

        private void Read_Logs_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "SELECT * FROM vehiculo";
                SqlCommand command = new SqlCommand(query, cc.Con);

                SqlDataReader reader = command.ExecuteReader();
                dt = new DataTable();

                dt.Load(reader);

                dataGridCar.DataSource = dt;

                dataGridCar.Columns[0].HeaderText = "Matrícula";
                dataGridCar.Columns[1].HeaderText = "Tipo de vehículo";
                dataGridCar.Columns[2].HeaderText = "Modelo";
                dataGridCar.Columns[3].HeaderText = "Fecha";
                dataGridCar.Columns[4].HeaderText = "Importe";
                dataGridCar.Columns[5].HeaderText = "Pagado";

                countCarLBL.Text = "Número de Vehículos: " + dt.Rows.Count.ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
