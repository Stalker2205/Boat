namespace WindowsFormsApp1
{
    partial class Password
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
            this.par1Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Par2Textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.salesPersonTableAdapter1 = new WindowsFormsApp1.DbBoatDataSetTableAdapters.SalesPersonTableAdapter();
            this.SuspendLayout();
            // 
            // par1Textbox
            // 
            this.par1Textbox.Location = new System.Drawing.Point(141, 12);
            this.par1Textbox.Name = "par1Textbox";
            this.par1Textbox.Size = new System.Drawing.Size(100, 20);
            this.par1Textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Подтверждение пароля";
            // 
            // Par2Textbox
            // 
            this.Par2Textbox.Location = new System.Drawing.Point(141, 39);
            this.Par2Textbox.Name = "Par2Textbox";
            this.Par2Textbox.Size = new System.Drawing.Size(100, 20);
            this.Par2Textbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salesPersonTableAdapter1
            // 
            this.salesPersonTableAdapter1.ClearBeforeFill = true;
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 104);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Par2Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.par1Textbox);
            this.Name = "Password";
            this.Text = "Password";
            this.Load += new System.EventHandler(this.Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox par1Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Par2Textbox;
        private System.Windows.Forms.Button button1;
        private DbBoatDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter1;
    }
}