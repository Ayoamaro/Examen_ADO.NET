
namespace Examen_ADO.NET
{
    partial class Execute_PyF
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
            this.secondFunction = new System.Windows.Forms.GroupBox();
            this.funcTypeCarTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCarLBL = new System.Windows.Forms.Label();
            this.showTotalBTN = new System.Windows.Forms.Button();
            this.firstProcedure = new System.Windows.Forms.GroupBox();
            this.dataGridProcedure = new System.Windows.Forms.DataGridView();
            this.carLBL = new System.Windows.Forms.Label();
            this.listCarBTN = new System.Windows.Forms.Button();
            this.typeCarTXT = new System.Windows.Forms.TextBox();
            this.typeCarLBL = new System.Windows.Forms.Label();
            this.secondFunction.SuspendLayout();
            this.firstProcedure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcedure)).BeginInit();
            this.SuspendLayout();
            // 
            // authorLBL
            // 
            this.authorLBL.AutoSize = true;
            this.authorLBL.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLBL.Location = new System.Drawing.Point(665, 155);
            this.authorLBL.Name = "authorLBL";
            this.authorLBL.Size = new System.Drawing.Size(136, 15);
            this.authorLBL.TabIndex = 14;
            this.authorLBL.Text = "Hecho por: Ayoze Amaro";
            this.authorLBL.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // secondFunction
            // 
            this.secondFunction.Controls.Add(this.funcTypeCarTXT);
            this.secondFunction.Controls.Add(this.label1);
            this.secondFunction.Controls.Add(this.totalCarLBL);
            this.secondFunction.Controls.Add(this.showTotalBTN);
            this.secondFunction.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondFunction.Location = new System.Drawing.Point(510, 24);
            this.secondFunction.Name = "secondFunction";
            this.secondFunction.Size = new System.Drawing.Size(454, 117);
            this.secondFunction.TabIndex = 13;
            this.secondFunction.TabStop = false;
            this.secondFunction.Text = "4ºFunción: Cantidad de vehículos de un mismo tipo";
            // 
            // funcTypeCarTXT
            // 
            this.funcTypeCarTXT.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcTypeCarTXT.Location = new System.Drawing.Point(118, 31);
            this.funcTypeCarTXT.Name = "funcTypeCarTXT";
            this.funcTypeCarTXT.Size = new System.Drawing.Size(156, 25);
            this.funcTypeCarTXT.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Tipo de Vehículo:";
            // 
            // totalCarLBL
            // 
            this.totalCarLBL.AutoSize = true;
            this.totalCarLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCarLBL.Location = new System.Drawing.Point(303, 76);
            this.totalCarLBL.Name = "totalCarLBL";
            this.totalCarLBL.Size = new System.Drawing.Size(108, 17);
            this.totalCarLBL.TabIndex = 34;
            this.totalCarLBL.Text = "Total de Vehículos:";
            // 
            // showTotalBTN
            // 
            this.showTotalBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTotalBTN.Location = new System.Drawing.Point(16, 64);
            this.showTotalBTN.Name = "showTotalBTN";
            this.showTotalBTN.Size = new System.Drawing.Size(281, 40);
            this.showTotalBTN.TabIndex = 32;
            this.showTotalBTN.Text = "Mostrar total";
            this.showTotalBTN.UseVisualStyleBackColor = true;
            this.showTotalBTN.Click += new System.EventHandler(this.showTotalBTN_Click);
            // 
            // firstProcedure
            // 
            this.firstProcedure.Controls.Add(this.dataGridProcedure);
            this.firstProcedure.Controls.Add(this.carLBL);
            this.firstProcedure.Controls.Add(this.listCarBTN);
            this.firstProcedure.Controls.Add(this.typeCarTXT);
            this.firstProcedure.Controls.Add(this.typeCarLBL);
            this.firstProcedure.Font = new System.Drawing.Font("Assistant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstProcedure.Location = new System.Drawing.Point(12, 24);
            this.firstProcedure.Name = "firstProcedure";
            this.firstProcedure.Size = new System.Drawing.Size(492, 480);
            this.firstProcedure.TabIndex = 12;
            this.firstProcedure.TabStop = false;
            this.firstProcedure.Text = "1ºProcedimiento: Listar vehículos según Tipo";
            // 
            // dataGridProcedure
            // 
            this.dataGridProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcedure.Location = new System.Drawing.Point(16, 89);
            this.dataGridProcedure.Name = "dataGridProcedure";
            this.dataGridProcedure.Size = new System.Drawing.Size(460, 378);
            this.dataGridProcedure.TabIndex = 43;
            // 
            // carLBL
            // 
            this.carLBL.AutoSize = true;
            this.carLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carLBL.Location = new System.Drawing.Point(212, 69);
            this.carLBL.Name = "carLBL";
            this.carLBL.Size = new System.Drawing.Size(63, 17);
            this.carLBL.TabIndex = 42;
            this.carLBL.Text = "Vehículos";
            this.carLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listCarBTN
            // 
            this.listCarBTN.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCarBTN.Location = new System.Drawing.Point(281, 24);
            this.listCarBTN.Name = "listCarBTN";
            this.listCarBTN.Size = new System.Drawing.Size(140, 30);
            this.listCarBTN.TabIndex = 41;
            this.listCarBTN.Text = "Listar vehículos";
            this.listCarBTN.UseVisualStyleBackColor = true;
            this.listCarBTN.Click += new System.EventHandler(this.listCarBTN_Click);
            // 
            // typeCarTXT
            // 
            this.typeCarTXT.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCarTXT.Location = new System.Drawing.Point(119, 27);
            this.typeCarTXT.Name = "typeCarTXT";
            this.typeCarTXT.Size = new System.Drawing.Size(156, 25);
            this.typeCarTXT.TabIndex = 40;
            // 
            // typeCarLBL
            // 
            this.typeCarLBL.AutoSize = true;
            this.typeCarLBL.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCarLBL.Location = new System.Drawing.Point(13, 31);
            this.typeCarLBL.Name = "typeCarLBL";
            this.typeCarLBL.Size = new System.Drawing.Size(100, 17);
            this.typeCarLBL.TabIndex = 39;
            this.typeCarLBL.Text = "Tipo de Vehículo:";
            // 
            // Execute_PyF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 516);
            this.Controls.Add(this.authorLBL);
            this.Controls.Add(this.secondFunction);
            this.Controls.Add(this.firstProcedure);
            this.Name = "Execute_PyF";
            this.Text = "Ejecutar Procedimientos y Funciones";
            this.secondFunction.ResumeLayout(false);
            this.secondFunction.PerformLayout();
            this.firstProcedure.ResumeLayout(false);
            this.firstProcedure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcedure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorLBL;
        private System.Windows.Forms.GroupBox secondFunction;
        private System.Windows.Forms.TextBox funcTypeCarTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCarLBL;
        private System.Windows.Forms.Button showTotalBTN;
        private System.Windows.Forms.GroupBox firstProcedure;
        private System.Windows.Forms.DataGridView dataGridProcedure;
        private System.Windows.Forms.Label carLBL;
        private System.Windows.Forms.Button listCarBTN;
        private System.Windows.Forms.TextBox typeCarTXT;
        private System.Windows.Forms.Label typeCarLBL;
    }
}