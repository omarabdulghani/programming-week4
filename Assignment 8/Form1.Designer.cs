namespace Assignment_8
{
    partial class Form1
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
            this.lblStartAmount = new System.Windows.Forms.Label();
            this.lblFinalCapital = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStartAmount
            // 
            this.lblStartAmount.AutoSize = true;
            this.lblStartAmount.Location = new System.Drawing.Point(25, 38);
            this.lblStartAmount.Name = "lblStartAmount";
            this.lblStartAmount.Size = new System.Drawing.Size(70, 13);
            this.lblStartAmount.TabIndex = 0;
            this.lblStartAmount.Text = "Start amount:";
            // 
            // lblFinalCapital
            // 
            this.lblFinalCapital.AutoSize = true;
            this.lblFinalCapital.Location = new System.Drawing.Point(189, 121);
            this.lblFinalCapital.Name = "lblFinalCapital";
            this.lblFinalCapital.Size = new System.Drawing.Size(13, 13);
            this.lblFinalCapital.TabIndex = 1;
            this.lblFinalCapital.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final capital:";
            // 
            // txtStartAmount
            // 
            this.txtStartAmount.Location = new System.Drawing.Point(132, 35);
            this.txtStartAmount.Name = "txtStartAmount";
            this.txtStartAmount.Size = new System.Drawing.Size(128, 20);
            this.txtStartAmount.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 71);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(232, 25);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate Final Capital";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 165);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtStartAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFinalCapital);
            this.Controls.Add(this.lblStartAmount);
            this.Name = "Form1";
            this.Text = "Assignment 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartAmount;
        private System.Windows.Forms.Label lblFinalCapital;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartAmount;
        private System.Windows.Forms.Button btnCalculate;
    }
}

