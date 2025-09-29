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

        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AdventureWorks2022;Integrated Security=True;";
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
                    query = "SELECT p.ProductID, p.Name AS ProductName, s.Name AS SubCategory \nFROM Production.Product p \nINNER JOIN Production.ProductSubcategory s \nON p.ProductSubcategoryID = s.ProductSubcategoryID;";
                    break;

                case 1:
                    query = "SELECT s.Name AS SubCategory, c.Name AS Category  \nFROM Production.ProductSubcategory s  \nINNER JOIN Production.ProductCategory c  \nON s.ProductCategoryID = c.ProductCategoryID;";
                    break;

                case 2:
                    query = "SELECT p.ProductID, p.Name AS ProductName, c.Name AS Category\nFROM Production.Product p\nINNER JOIN Production.ProductSubcategory s ON p.ProductSubcategoryID = s.ProductSubcategoryID\nINNER JOIN Production.ProductCategory c ON s.ProductCategoryID = c.ProductCategoryID;";
                    break;

                case 3:
                    query = "SELECT p.ProductID, p.Name, ph.ThumbnailPhotoFileName, ph.LargePhotoFileName\nFROM Production.Product p\nINNER JOIN Production.ProductProductPhoto pp ON p.ProductID = pp.ProductID\nINNER JOIN Production.ProductPhoto ph ON pp.ProductPhotoID = ph.ProductPhotoID;";
                    break;

                case 4:
                    query = "SELECT p.ProductID, p.Name, r.ReviewerName, r.Rating, r.Comments\nFROM Production.Product p\nINNER JOIN Production.ProductReview r ON p.ProductID = r.ProductID;";
                    break;

                case 5:
                    query = "SELECT p.ProductID, p.Name, i.LocationID, i.Quantity\nFROM Production.Product p\nINNER JOIN Production.ProductInventory i ON p.ProductID = i.ProductID;";
                    break;

                case 6:
                    query = "SELECT i.ProductID, l.LocationID, l.Name AS LocationName, i.Quantity\nFROM Production.ProductInventory i\nINNER JOIN Production.Location l ON i.LocationID = l.LocationID;";
                    break;

                case 7:
                    query = "SELECT p.ProductID, p.Name, w.WorkOrderID, w.OrderQty, w.ScrappedQty\nFROM Production.Product p\nINNER JOIN Production.WorkOrder w ON p.ProductID = w.ProductID;";
                    break;

                case 8:
                    query = "SELECT w.WorkOrderID, w.ProductID, w.ScrappedQty, s.Name AS ScrapReason\nFROM Production.WorkOrder w\nINNER JOIN Production.ScrapReason s ON w.ScrapReasonID = s.ScrapReasonID;";
                    break;

                case 9:
                    query = "SELECT p.ProductID, p.Name, t.TransactionID, t.TransactionDate, t.Quantity, t.ActualCost\nFROM Production.Product p\nINNER JOIN Production.TransactionHistory t ON p.ProductID = t.ProductID;";
                    break;

                default:
                    MessageBox.Show("Selecciona una consulta");
                    return;
            }
            // Ahora ejecutamos la consulta y mostramos en un DataGridView
            using (SqlConnection con = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=AdventureWorks2022;Trusted_Connection=True;Encrypt=False;"))
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
