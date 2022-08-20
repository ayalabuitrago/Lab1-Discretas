
namespace Lab1_Discretas
{
    partial class FTrueTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.TBcant = new System.Windows.Forms.TextBox();
            this.DGVtablaDeVerdad = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoperator = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNgen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVtablaDeVerdad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de proposiciones:";
            // 
            // TBcant
            // 
            this.TBcant.Location = new System.Drawing.Point(153, 23);
            this.TBcant.Name = "TBcant";
            this.TBcant.Size = new System.Drawing.Size(79, 20);
            this.TBcant.TabIndex = 1;
            this.TBcant.TextChanged += new System.EventHandler(this.TBcant_TextChanged);
            // 
            // DGVtablaDeVerdad
            // 
            this.DGVtablaDeVerdad.AllowUserToAddRows = false;
            this.DGVtablaDeVerdad.AllowUserToDeleteRows = false;
            this.DGVtablaDeVerdad.AllowUserToResizeColumns = false;
            this.DGVtablaDeVerdad.AllowUserToResizeRows = false;
            this.DGVtablaDeVerdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVtablaDeVerdad.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVtablaDeVerdad.Location = new System.Drawing.Point(15, 128);
            this.DGVtablaDeVerdad.Name = "DGVtablaDeVerdad";
            this.DGVtablaDeVerdad.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVtablaDeVerdad.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVtablaDeVerdad.RowHeadersVisible = false;
            this.DGVtablaDeVerdad.Size = new System.Drawing.Size(420, 133);
            this.DGVtablaDeVerdad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Operador Lógico";
            // 
            // CBoperator
            // 
            this.CBoperator.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBoperator.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBoperator.FormattingEnabled = true;
            this.CBoperator.Items.AddRange(new object[] {
            "Conjución",
            "Disyunción",
            "Implicación",
            "Doble Implicación"});
            this.CBoperator.Location = new System.Drawing.Point(341, 26);
            this.CBoperator.Name = "CBoperator";
            this.CBoperator.Size = new System.Drawing.Size(102, 21);
            this.CBoperator.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tabla de verdad";
            // 
            // BTNgen
            // 
            this.BTNgen.Location = new System.Drawing.Point(15, 54);
            this.BTNgen.Name = "BTNgen";
            this.BTNgen.Size = new System.Drawing.Size(97, 23);
            this.BTNgen.TabIndex = 6;
            this.BTNgen.Text = "Generar Tabla";
            this.BTNgen.UseVisualStyleBackColor = true;
            this.BTNgen.Click += new System.EventHandler(this.BTNgen_Click);
            // 
            // FTrueTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 278);
            this.Controls.Add(this.BTNgen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBoperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVtablaDeVerdad);
            this.Controls.Add(this.TBcant);
            this.Controls.Add(this.label1);
            this.Name = "FTrueTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de Verdad";
            this.Load += new System.EventHandler(this.FTrueTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVtablaDeVerdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBcant;
        private System.Windows.Forms.DataGridView DGVtablaDeVerdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNgen;
    }
}