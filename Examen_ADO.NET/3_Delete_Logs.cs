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
    public partial class Delete_Logs : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da_Car;

        public Delete_Logs()
        {
            InitializeComponent();
        }

        private void loadRecordBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "SELECT * FROM vehiculo WHERE matricula='" + codCarTXT.Text + "'";
                da_Car = new SqlDataAdapter(query, cc.Con);

                da_Car.Fill(ds, "vehiculo");

                identityTXT.Text = ds.Tables["vehiculo"].Rows[0]["matricula"].ToString();
                typeCarTXT.Text = ds.Tables["vehiculo"].Rows[0]["tipo"].ToString();
                modelTXT.Text = ds.Tables["vehiculo"].Rows[0]["modelo"].ToString();
                datePICK.Text = ds.Tables["vehiculo"].Rows[0]["fecha"].ToString();
                priceTXT.Text = ds.Tables["vehiculo"].Rows[0]["importe"].ToString();
                payCHK.Checked = Convert.ToBoolean(ds.Tables["vehiculo"].Rows[0]["pagado"]);

                ds.Clear();

                cc.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }

        private void deleteCarBTN_Click(object sender, EventArgs e)
        {
            Connection cc = new Connection();
            try
            {
                cc.Con.Open();

                String query = "DELETE FROM vehiculo WHERE matricula=@matricula";
                da_Car = new SqlDataAdapter();
                da_Car.DeleteCommand = new SqlCommand(query, cc.Con);

                da_Car.DeleteCommand.Parameters.Add("@matricula", SqlDbType.VarChar).Value = codCarTXT.Text;
                da_Car.DeleteCommand.ExecuteNonQuery();

                cc.Con.Close();
                MessageBox.Show("Registro (" + codCarTXT.Text + ") borrado.");

                identityTXT.Text = "";
                typeCarTXT.Text = "";
                modelTXT.Text = "";
                datePICK.Text = "";
                priceTXT.Text = "";
                payCHK.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
