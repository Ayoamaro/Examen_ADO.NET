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
    public partial class Combo_DataGrid : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_TypeCar, da_Car;

        public Combo_DataGrid()
        {
            InitializeComponent();
        }

        private void Combo_DataGrid_Load(object sender, EventArgs e)
        {
            try
            {
                Connection cc = new Connection();
                cc.Con.Open();

                String query;

                /* Tipos de Vehículos */
                query = "SELECT * FROM tipo_vehiculo";
                da_TypeCar = new SqlDataAdapter(query, cc.Con);
                da_TypeCar.Fill(ds, "tipo_vehiculo");

                DataView dv_TypeCar = new DataView(ds.Tables["tipo_vehiculo"]);
                dataGridTypeCar.DataSource = dv_TypeCar;

                dataGridTypeCar.Columns[0].HeaderText = "Tipo de Vehículo";
                dataGridTypeCar.Columns[1].HeaderText = "Descripción";

                countTypeCarLBL.Text = "Número de Tipos de Vehículos: " + ds.Tables["tipo_vehiculo"].Rows.Count.ToString();

                /* Vehículos */
                query = "SELECT * FROM vehiculo";
                da_Car = new SqlDataAdapter(query, cc.Con);
                da_Car.Fill(ds, "vehiculo");

                DataView dv_Car = new DataView(ds.Tables["vehiculo"]);
                dataGridCar.DataSource = dv_Car;

                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.DataPropertyName = "tipo";
                cmb.DisplayMember = "descripcion";
                cmb.ValueMember = "tipo";
                cmb.DataSource = dv_TypeCar;
                dataGridCar.Columns.Add(cmb);

                dataGridCar.Columns[0].HeaderText = "Matrícula";
                dataGridCar.Columns[1].HeaderText = "Tipo de Vehículo";
                dataGridCar.Columns[2].HeaderText = "Modelo";
                dataGridCar.Columns[3].HeaderText = "Fecha";
                dataGridCar.Columns[4].HeaderText = "Importe";
                dataGridCar.Columns[5].HeaderText = "Pagado";
                dataGridCar.Columns[6].HeaderText = "Tipo de Vehículo";

                dataGridCar.Columns[1].Visible = false;

                countCarLBL.Text = "Número de Vehículos: " + ds.Tables["vehiculo"].Rows.Count.ToString();

                cc.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void saveDataBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder commandBuilderLeague = new SqlCommandBuilder(da_TypeCar);
                da_TypeCar.Update(ds.Tables["tipo_vehiculo"]);

                countTypeCarLBL.Text = "Número de Tipos de Vehículos: " + ds.Tables["tipo_vehiculo"].Rows.Count.ToString();

                SqlCommandBuilder commandBuilderTeam = new SqlCommandBuilder(da_Car);
                da_Car.Update(ds.Tables["vehiculo"]);

                countCarLBL.Text = "Número de Vehículos: " + ds.Tables["vehiculo"].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
