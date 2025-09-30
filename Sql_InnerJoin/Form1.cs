using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Sql_InnerJoin
{
    public partial class Form1 : Form
    {

        private string connectionString = "Server=192.168.1.13\\SQLEXPRESS,1433;Database=AdventureWorks2022;User Id=TEST;Password=12345678;Encrypt=False;";
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsertInner_Click(object sender, EventArgs e)
        {
            string query = "";

            switch (ComBoxSeleccion.SelectedIndex)
            {
                case 0:
                    query = "SELECT * FROM Vista_Producto_SubCategoria";
                    break;
                case 1:
                    query = "SELECT * FROM Vista_SubCategoria_Categoria";
                    break;

                case 2:
                    query = "SELECT * FROM Vista_Producto_Subcategoria_Producto";
                    break;

                case 3:
                    query = "SELECT * FROM Vista_Producto_Fotos";
                    break;

                case 4:
                    query = "SELECT * FROM Vista_Producto_Reseña";
                    break;

                case 5:
                    query = "SELECT * FROM Vista_Producto_Inventario";
                    break;

                case 6:
                    query = "SELECT * FROM Vista_Inventario_Ubicacion";
                    break;

                case 7:
                    query = "SELECT * FROM Vista_Producto_OrdenesTrabajo";
                    break;

                case 8:
                    query = "SELECT * FROM Vista_OrdenesTrabajo_RazonDespido";
                    break;

                case 9:
                    query = "SELECT * FROM Vista_Producto_Historial";
                    break;

                default:
                    MessageBox.Show("Selecciona una consulta");
                    return;
            }
            // Ahora ejecutamos la consulta y mostramos en un DataGridView
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvViewInnerJoin.DataSource = dt;
            }
        }

        private void ComBoxSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
