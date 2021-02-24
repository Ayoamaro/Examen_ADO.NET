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
    public partial class DataGrid_Relation : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_TypeCar, da_Car;

        DataView dv_TypeCar = new DataView();
        DataRowView currentRowView;

        public DataGrid_Relation()
        {
            InitializeComponent();
        }

        private void DataGrid_Relation_Load(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query;

                /* Tipos de Vehículos */
                query = "SELECT * FROM tipo_vehiculo";
                da_TypeCar = new SqlDataAdapter(query, cc.Con);
                da_TypeCar.Fill(ds, "tipo_vehiculo");

                /* Vehículos */
                query = "SELECT * FROM vehiculo";
                da_Car = new SqlDataAdapter(query, cc.Con);
                da_Car.Fill(ds, "vehiculo");

                DataColumn parentColumn = ds.Tables["tipo_vehiculo"].Columns["tipo"];
                DataColumn childColumn = ds.Tables["vehiculo"].Columns["tipo"];
                DataRelation relCustOrder;
                relCustOrder = new DataRelation("TiposDeVehículosYVehículos", parentColumn, childColumn);
                ds.Relations.Add(relCustOrder);

                /* Tipos de Vehículos */
                dv_TypeCar = new DataView(ds.Tables["tipo_vehiculo"]);
                dataGridTypeCar.DataSource = dv_TypeCar;

                currentRowView = dv_TypeCar[dataGridTypeCar.CurrentRow.Index];

                dataGridTypeCar.Columns[0].HeaderText = "Tipo de Vehículo";
                dataGridTypeCar.Columns[1].HeaderText = "Descripción";

                countTypeCarLBL.Text = "Número de Tipos de Vehículos: " + ds.Tables["tipo_vehiculo"].Rows.Count.ToString();

                /* Vehículos */
                dataGridCar.DataSource = currentRowView.CreateChildView("TiposDeVehículosYVehículos");

                dataGridCar.Columns[0].HeaderText = "Matrícula";
                dataGridCar.Columns[1].HeaderText = "Tipo de Vehículo";
                dataGridCar.Columns[2].HeaderText = "Modelo";
                dataGridCar.Columns[3].HeaderText = "Fecha";
                dataGridCar.Columns[4].HeaderText = "Importe";
                dataGridCar.Columns[5].HeaderText = "Pagado";

                countCarLBL.Text = "Número de Vehículos: " + currentRowView.CreateChildView("TiposDeVehículosYVehículos").Count.ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void dataGridTypeCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                currentRowView = dv_TypeCar[dataGridTypeCar.CurrentRow.Index];
                dataGridCar.DataSource = currentRowView.CreateChildView("TiposDeVehículosYVehículos");

                countCarLBL.Text = "Número de Vehículos: " + (dataGridCar.RowCount - 1).ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
