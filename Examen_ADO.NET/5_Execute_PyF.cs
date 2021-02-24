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
    public partial class Execute_PyF : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Car;

        public Execute_PyF()
        {
            InitializeComponent();
        }

        private void listCarBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "EXEC listavehiculos @tipo= '" + typeCarTXT.Text + "'";
                da_Car = new SqlDataAdapter(query, cc.Con);
                da_Car.Fill(ds, "vehiculo");

                DataView dv_Cars = new DataView(ds.Tables["vehiculo"]);
                dataGridProcedure.DataSource = dv_Cars;

                dataGridProcedure.Columns[0].HeaderText = "Matrícula";
                dataGridProcedure.Columns[1].HeaderText = "Tipo de Vehículo";
                dataGridProcedure.Columns[2].HeaderText = "Modelo";
                dataGridProcedure.Columns[3].HeaderText = "Fecha";
                dataGridProcedure.Columns[4].HeaderText = "Importe";
                dataGridProcedure.Columns[5].HeaderText = "Pagado";

                cc.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void showTotalBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "SELECT dbo.Numerovehiculosportipo ('" + funcTypeCarTXT.Text + "')";
                SqlCommand command = new SqlCommand(query, cc.Con);

                totalCarLBL.Text = "Total de Vehículos: " + command.ExecuteScalar();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
