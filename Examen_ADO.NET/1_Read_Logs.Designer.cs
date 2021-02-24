
namespace Examen_ADO.NET
{
    partial class Read_Logs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorLBL = new System.Windows.Forms.Label();
            this.countCarLBL = new System.Windows.Forms.Label();
            this.dataGridCar = new System.Windows.Forms.DataGridView();
            this.carLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(121, 320);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 19;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // countCarLBL
            // 
            this.countCarLBL.AutoSize = true;
            this.countCarLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countCarLBL.Location = new System.Drawing.Point(23, 291);
            this.countCarLBL.Name = "countCarLBL";
            this.countCarLBL.Size = new System.Drawing.Size(124, 17);
            this.countCarLBL.TabIndex = 18;
            this.countCarLBL.Text = "Número de Vehículos:";
            // 
            // dataGridCar
            // 
            this.dataGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCar.Location = new System.Drawing.Point(23, 33);
            this.dataGridCar.Name = "dataGridCar";
            this.dataGridCar.Size = new System.Drawing.Size(330, 245);
            this.dataGridCar.TabIndex = 17;
            // 
            // carLBL
            // 
            this.carLBL.AutoSize = true;
            this.carLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLBL.Location = new System.Drawing.Point(149, 14);
            this.carLBL.Name = "carLBL";
            this.carLBL.Size = new System.Drawing.Size(63, 17);
            this.carLBL.TabIndex = 16;
            this.carLBL.Text = "Vehículos";
            this.carLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Read_Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 353);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.countCarLBL);
            this.Controls.Add(this.dataGridCar);
            this.Controls.Add(this.carLBL);
            this.Name = "Read_Logs";
            this.Text = "Leer registros de tabla";
            this.Load += new System.EventHandler(this.Read_Logs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.Label countCarLBL;
        private System.Windows.Forms.DataGridView dataGridCar;
        private System.Windows.Forms.Label carLBL;
    }
}