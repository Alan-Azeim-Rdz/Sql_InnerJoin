namespace Sql_InnerJoin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnInsertInner = new Button();
            ComBoxSeleccion = new ComboBox();
            DgvViewInnerJoin = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvViewInnerJoin).BeginInit();
            SuspendLayout();
            // 
            // BtnInsertInner
            // 
            BtnInsertInner.Location = new Point(80, 132);
            BtnInsertInner.Name = "BtnInsertInner";
            BtnInsertInner.Size = new Size(147, 52);
            BtnInsertInner.TabIndex = 0;
            BtnInsertInner.Text = "Insertar";
            BtnInsertInner.UseVisualStyleBackColor = true;
            BtnInsertInner.Click += BtnInsertInner_Click;
            // 
            // ComBoxSeleccion
            // 
            ComBoxSeleccion.FormattingEnabled = true;
            ComBoxSeleccion.Items.AddRange(new object[] { "Producto-Subcategoria", "Subcategoria-Categoria", "Producto-Subcategoria-Producto", "Producto-Fotos", "Producto-Reseña", "Producto-InventarioBodega", "Inventario-Ubicacion", "Producto-OrdenesTrabajo", "OrdenesTrabajo-RazonDespido", "Producto-Historial" });
            ComBoxSeleccion.Location = new Point(80, 41);
            ComBoxSeleccion.Name = "ComBoxSeleccion";
            ComBoxSeleccion.Size = new Size(121, 23);
            ComBoxSeleccion.TabIndex = 1;
            ComBoxSeleccion.SelectedIndexChanged += ComBoxSeleccion_SelectedIndexChanged;
            // 
            // DgvViewInnerJoin
            // 
            DgvViewInnerJoin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvViewInnerJoin.Location = new Point(491, 41);
            DgvViewInnerJoin.Name = "DgvViewInnerJoin";
            DgvViewInnerJoin.Size = new Size(554, 419);
            DgvViewInnerJoin.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 503);
            Controls.Add(DgvViewInnerJoin);
            Controls.Add(ComBoxSeleccion);
            Controls.Add(BtnInsertInner);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvViewInnerJoin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnInsertInner;
        private ComboBox ComBoxSeleccion;
        private DataGridView DgvViewInnerJoin;
    }
}
