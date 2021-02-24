
namespace Examen_ADO.NET
{
    partial class Combo_DataGrid
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
            this.saveDataBTN = new System.Windows.Forms.Button();
            this.countCarLBL = new System.Windows.Forms.Label();
            this.dataGridCar = new System.Windows.Forms.DataGridView();
            this.carLBL = new System.Windows.Forms.Label();
            this.countTypeCarLBL = new System.Windows.Forms.Label();
            this.dataGridTypeCar = new System.Windows.Forms.DataGridView();
            this.typeCarLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(550, 344);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 28;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // saveDataBTN
            // 
            this.saveDataBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataBTN.Location = new System.Drawing.Point(111, 329);
            this.saveDataBTN.Name = "saveDataBTN";
            this.saveDataBTN.Size = new System.Drawing.Size(400, 45);
            this.saveDataBTN.TabIndex = 27;
            this.saveDataBTN.Text = "Guardar Datos";
            this.saveDataBTN.UseVisualStyleBackColor = true;
            this.saveDataBTN.Click += new System.EventHandler(this.saveDataBTN_Click);
            // 
            // countCarLBL
            // 
            this.countCarLBL.AutoSize = true;
            this.countCarLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countCarLBL.Location = new System.Drawing.Point(374, 295);
            this.countCarLBL.Name = "countCarLBL";
            this.countCarLBL.Size = new System.Drawing.Size(124, 17);
            this.countCarLBL.TabIndex = 26;
            this.countCarLBL.Text = "Número de Vehículos:";
            // 
            // dataGridCar
            // 
            this.dataGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCar.Location = new System.Drawing.Point(374, 37);
            this.dataGridCar.Name = "dataGridCar";
            this.dataGridCar.Size = new System.Drawing.Size(680, 245);
            this.dataGridCar.TabIndex = 25;
            // 
            // carLBL
            // 
            this.carLBL.AutoSize = true;
            this.carLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLBL.Location = new System.Drawing.Point(671, 17);
            this.carLBL.Name = "carLBL";
            this.carLBL.Size = new System.Drawing.Size(63, 17);
            this.carLBL.TabIndex = 24;
            this.carLBL.Text = "Vehículos";
            this.carLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // countTypeCarLBL
            // 
            this.countTypeCarLBL.AutoSize = true;
            this.countTypeCarLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countTypeCarLBL.Location = new System.Drawing.Point(23, 295);
            this.countTypeCarLBL.Name = "countTypeCarLBL";
            this.countTypeCarLBL.Size = new System.Drawing.Size(172, 17);
            this.countTypeCarLBL.TabIndex = 23;
            this.countTypeCarLBL.Text = "Número de Tipos de Vehículos:";
            // 
            // dataGridTypeCar
            // 
            this.dataGridTypeCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTypeCar.Location = new System.Drawing.Point(23, 37);
            this.dataGridTypeCar.Name = "dataGridTypeCar";
            this.dataGridTypeCar.Size = new System.Drawing.Size(330, 245);
            this.dataGridTypeCar.TabIndex = 22;
            // 
            // typeCarLBL
            // 
            this.typeCarLBL.AutoSize = true;
            this.typeCarLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCarLBL.Location = new System.Drawing.Point(121, 17);
            this.typeCarLBL.Name = "typeCarLBL";
            this.typeCarLBL.Size = new System.Drawing.Size(114, 17);
            this.typeCarLBL.TabIndex = 21;
            this.typeCarLBL.Text = "Tipos de Vehículos";
            this.typeCarLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Combo_DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 393);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.saveDataBTN);
            this.Controls.Add(this.countCarLBL);
            this.Controls.Add(this.dataGridCar);
            this.Controls.Add(this.carLBL);
            this.Controls.Add(this.countTypeCarLBL);
            this.Controls.Add(this.dataGridTypeCar);
            this.Controls.Add(this.typeCarLBL);
            this.Name = "Combo_DataGrid";
            this.Text = "Utilizar ComboBox dentro de DataGrid";
            this.Load += new System.EventHandler(this.Combo_DataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTypeCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.Button saveDataBTN;
        private System.Windows.Forms.Label countCarLBL;
        private System.Windows.Forms.DataGridView dataGridCar;
        private System.Windows.Forms.Label carLBL;
        private System.Windows.Forms.Label countTypeCarLBL;
        private System.Windows.Forms.DataGridView dataGridTypeCar;
        private System.Windows.Forms.Label typeCarLBL;
    }
}