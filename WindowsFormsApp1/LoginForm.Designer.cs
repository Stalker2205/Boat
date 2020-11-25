namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label loginLabel;
            this.dbBoatDataSet = new WindowsFormsApp1.DbBoatDataSet();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesPersonTableAdapter = new WindowsFormsApp1.DbBoatDataSetTableAdapters.SalesPersonTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DbBoatDataSetTableAdapters.TableAdapterManager();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            passwordLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbBoatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(15, 41);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(35, 15);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Login:";
            // 
            // dbBoatDataSet
            // 
            this.dbBoatDataSet.DataSetName = "DbBoatDataSet";
            this.dbBoatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessoriesToBoatTableAdapter = null;
            this.tableAdapterManager.AccessoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoatTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PartnerTableAdapter = null;
            this.tableAdapterManager.SalesPersonTableAdapter = this.salesPersonTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DbBoatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(77, 12);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextbox.TabIndex = 4;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(77, 38);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextbox.TabIndex = 5;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(77, 64);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 23);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 111);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.LoginTextbox);
            this.Controls.Add(loginLabel);
            this.Controls.Add(passwordLabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBoatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbBoatDataSet dbBoatDataSet;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private DbBoatDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private DbBoatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Button LoginButton;
    }
}