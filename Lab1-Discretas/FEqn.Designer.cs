
namespace Lab1_Discretas
{
    partial class FEqn
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
            this.BTNeq1 = new System.Windows.Forms.RadioButton();
            this.LbR = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BTNeq1
            // 
            this.BTNeq1.AutoSize = true;
            this.BTNeq1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNeq1.Location = new System.Drawing.Point(29, 89);
            this.BTNeq1.Name = "BTNeq1";
            this.BTNeq1.Size = new System.Drawing.Size(168, 28);
            this.BTNeq1.TabIndex = 0;
            this.BTNeq1.Text = "(X<10 || X>20) ";
            this.BTNeq1.UseVisualStyleBackColor = true;
            this.BTNeq1.CheckedChanged += new System.EventHandler(this.BTNeq1_CheckedChanged);
            // 
            // LbR
            // 
            this.LbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbR.FormattingEnabled = true;
            this.LbR.ItemHeight = 20;
            this.LbR.Location = new System.Drawing.Point(25, 246);
            this.LbR.Name = "LbR";
            this.LbR.Size = new System.Drawing.Size(681, 164);
            this.LbR.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Demostrar que las siguientes ecuaciones son equivalentes , con x - { 0, 100}";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(29, 156);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(208, 28);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = " !(X>=10 &&  X<=20)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FEqn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 425);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbR);
            this.Controls.Add(this.BTNeq1);
            this.Name = "FEqn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FEqn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BTNeq1;
        private System.Windows.Forms.ListBox LbR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}