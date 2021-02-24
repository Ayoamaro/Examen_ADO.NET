
namespace Examen_ADO.NET
{
    partial class Main_Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorLBL = new System.Windows.Forms.Label();
            this.executePyFBTN = new System.Windows.Forms.Button();
            this.relationDataGridBTN = new System.Windows.Forms.Button();
            this.deleteLogsBTN = new System.Windows.Forms.Button();
            this.comboDataGridBTN = new System.Windows.Forms.Button();
            this.readLogsBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(234, 191);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 16;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // executePyFBTN
            // 
            this.executePyFBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executePyFBTN.Location = new System.Drawing.Point(172, 129);
            this.executePyFBTN.Name = "executePyFBTN";
            this.executePyFBTN.Size = new System.Drawing.Size(285, 48);
            this.executePyFBTN.TabIndex = 15;
            this.executePyFBTN.Text = "Ejecutar Procedimientos y Funciones";
            this.executePyFBTN.UseVisualStyleBackColor = true;
            this.executePyFBTN.Click += new System.EventHandler(this.executePyFBTN_Click);
            // 
            // relationDataGridBTN
            // 
            this.relationDataGridBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationDataGridBTN.Location = new System.Drawing.Point(312, 75);
            this.relationDataGridBTN.Name = "relationDataGridBTN";
            this.relationDataGridBTN.Size = new System.Drawing.Size(285, 48);
            this.relationDataGridBTN.TabIndex = 14;
            this.relationDataGridBTN.Text = "DataGrid relacionados";
            this.relationDataGridBTN.UseVisualStyleBackColor = true;
            this.relationDataGridBTN.Click += new System.EventHandler(this.relationDataGridBTN_Click);
            // 
            // deleteLogsBTN
            // 
            this.deleteLogsBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLogsBTN.Location = new System.Drawing.Point(21, 75);
            this.deleteLogsBTN.Name = "deleteLogsBTN";
            this.deleteLogsBTN.Size = new System.Drawing.Size(285, 48);
            this.deleteLogsBTN.TabIndex = 13;
            this.deleteLogsBTN.Text = "Borrado de un registro";
            this.deleteLogsBTN.UseVisualStyleBackColor = true;
            this.deleteLogsBTN.Click += new System.EventHandler(this.deleteLogsBTN_Click);
            // 
            // comboDataGridBTN
            // 
            this.comboDataGridBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDataGridBTN.Location = new System.Drawing.Point(312, 21);
            this.comboDataGridBTN.Name = "comboDataGridBTN";
            this.comboDataGridBTN.Size = new System.Drawing.Size(285, 48);
            this.comboDataGridBTN.TabIndex = 12;
            this.comboDataGridBTN.Text = "Utilizar ComboBox dentro de DataGrid";
            this.comboDataGridBTN.UseVisualStyleBackColor = true;
            this.comboDataGridBTN.Click += new System.EventHandler(this.comboDataGridBTN_Click);
            // 
            // readLogsBTN
            // 
            this.readLogsBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readLogsBTN.Location = new System.Drawing.Point(21, 21);
            this.readLogsBTN.Name = "readLogsBTN";
            this.readLogsBTN.Size = new System.Drawing.Size(285, 48);
            this.readLogsBTN.TabIndex = 11;
            this.readLogsBTN.Text = "Leer registros de tabla";
            this.readLogsBTN.UseVisualStyleBackColor = true;
            this.readLogsBTN.Click += new System.EventHandler(this.readLogsBTN_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 220);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.executePyFBTN);
            this.Controls.Add(this.relationDataGridBTN);
            this.Controls.Add(this.deleteLogsBTN);
            this.Controls.Add(this.comboDataGridBTN);
            this.Controls.Add(this.readLogsBTN);
            this.Name = "Main_Menu";
            this.Text = "Proyecto de Concesionario de Coches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.Button executePyFBTN;
        private System.Windows.Forms.Button relationDataGridBTN;
        private System.Windows.Forms.Button deleteLogsBTN;
        private System.Windows.Forms.Button comboDataGridBTN;
        private System.Windows.Forms.Button readLogsBTN;
    }
}

