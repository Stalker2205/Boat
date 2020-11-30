namespace WindowsFormsApp1
{
    partial class UpdateBoat
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label boatTypeLabel;
            System.Windows.Forms.Label numberOfRowersLabel;
            System.Windows.Forms.Label mastLabel;
            System.Windows.Forms.Label colourLabel;
            System.Windows.Forms.Label woodLabel;
            System.Windows.Forms.Label basePriceLabel;
            this.dbBoatDataSet = new WindowsFormsApp1.DbBoatDataSet();
            this.boatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boatTableAdapter = new WindowsFormsApp1.DbBoatDataSetTableAdapters.BoatTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DbBoatDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.boatTypeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfRowersTextBox = new System.Windows.Forms.TextBox();
            this.mastCheckBox = new System.Windows.Forms.CheckBox();
            this.basePriceTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            boatTypeLabel = new System.Windows.Forms.Label();
            numberOfRowersLabel = new System.Windows.Forms.Label();
            mastLabel = new System.Windows.Forms.Label();
            colourLabel = new System.Windows.Forms.Label();
            woodLabel = new System.Windows.Forms.Label();
            basePriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbBoatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(82, 15);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(64, 41);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model:";
            // 
            // boatTypeLabel
            // 
            boatTypeLabel.AutoSize = true;
            boatTypeLabel.Location = new System.Drawing.Point(44, 67);
            boatTypeLabel.Name = "boatTypeLabel";
            boatTypeLabel.Size = new System.Drawing.Size(59, 13);
            boatTypeLabel.TabIndex = 5;
            boatTypeLabel.Text = "Boat Type:";
            // 
            // numberOfRowersLabel
            // 
            numberOfRowersLabel.AutoSize = true;
            numberOfRowersLabel.Location = new System.Drawing.Point(3, 93);
            numberOfRowersLabel.Name = "numberOfRowersLabel";
            numberOfRowersLabel.Size = new System.Drawing.Size(100, 13);
            numberOfRowersLabel.TabIndex = 7;
            numberOfRowersLabel.Text = "Number Of Rowers:";
            // 
            // mastLabel
            // 
            mastLabel.AutoSize = true;
            mastLabel.Location = new System.Drawing.Point(70, 121);
            mastLabel.Name = "mastLabel";
            mastLabel.Size = new System.Drawing.Size(33, 13);
            mastLabel.TabIndex = 9;
            mastLabel.Text = "Mast:";
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Location = new System.Drawing.Point(63, 149);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new System.Drawing.Size(40, 13);
            colourLabel.TabIndex = 11;
            colourLabel.Text = "Colour:";
            // 
            // woodLabel
            // 
            woodLabel.AutoSize = true;
            woodLabel.Location = new System.Drawing.Point(64, 175);
            woodLabel.Name = "woodLabel";
            woodLabel.Size = new System.Drawing.Size(39, 13);
            woodLabel.TabIndex = 12;
            woodLabel.Text = "Wood:";
            // 
            // basePriceLabel
            // 
            basePriceLabel.AutoSize = true;
            basePriceLabel.Location = new System.Drawing.Point(42, 201);
            basePriceLabel.Name = "basePriceLabel";
            basePriceLabel.Size = new System.Drawing.Size(61, 13);
            basePriceLabel.TabIndex = 14;
            basePriceLabel.Text = "Base Price:";
            // 
            // dbBoatDataSet
            // 
            this.dbBoatDataSet.DataSetName = "DbBoatDataSet";
            this.dbBoatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boatBindingSource
            // 
            this.boatBindingSource.DataMember = "Boat";
            this.boatBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // boatTableAdapter
            // 
            this.boatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessoriesToBoatTableAdapter = null;
            this.tableAdapterManager.AccessoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoatTableAdapter = this.boatTableAdapter;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PartnerTableAdapter = null;
            this.tableAdapterManager.SalesPersonTableAdapter = null;
            this.tableAdapterManager.Table_1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DbBoatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(109, 12);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // boatTypeTextBox
            // 
            this.boatTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "BoatType", true));
            this.boatTypeTextBox.Location = new System.Drawing.Point(109, 64);
            this.boatTypeTextBox.Name = "boatTypeTextBox";
            this.boatTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.boatTypeTextBox.TabIndex = 6;
            // 
            // numberOfRowersTextBox
            // 
            this.numberOfRowersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "NumberOfRowers", true));
            this.numberOfRowersTextBox.Location = new System.Drawing.Point(109, 90);
            this.numberOfRowersTextBox.Name = "numberOfRowersTextBox";
            this.numberOfRowersTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfRowersTextBox.TabIndex = 8;
            // 
            // mastCheckBox
            // 
            this.mastCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.boatBindingSource, "Mast", true));
            this.mastCheckBox.Location = new System.Drawing.Point(109, 116);
            this.mastCheckBox.Name = "mastCheckBox";
            this.mastCheckBox.Size = new System.Drawing.Size(104, 24);
            this.mastCheckBox.TabIndex = 10;
            this.mastCheckBox.UseVisualStyleBackColor = true;
            // 
            // basePriceTextBox
            // 
            this.basePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.boatBindingSource, "BasePrice", true));
            this.basePriceTextBox.Location = new System.Drawing.Point(109, 198);
            this.basePriceTextBox.Name = "basePriceTextBox";
            this.basePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.basePriceTextBox.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Стандарт",
            "Эконом",
            "Люкс"});
            this.comboBox1.Location = new System.Drawing.Point(109, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Стандарт";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Коричневый",
            "белый",
            "черный",
            "зеленый",
            "красный",
            "синий"});
            this.comboBox2.Location = new System.Drawing.Point(109, 146);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "Коричневый";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "дуб",
            "березаель",
            "ель",
            "сосна ",
            "лиственница"});
            this.comboBox3.Location = new System.Drawing.Point(109, 172);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.Text = "дуб";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 26);
            this.button2.TabIndex = 23;
            this.button2.Text = "Форум";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(basePriceLabel);
            this.Controls.Add(this.basePriceTextBox);
            this.Controls.Add(woodLabel);
            this.Controls.Add(colourLabel);
            this.Controls.Add(mastLabel);
            this.Controls.Add(this.mastCheckBox);
            this.Controls.Add(numberOfRowersLabel);
            this.Controls.Add(this.numberOfRowersTextBox);
            this.Controls.Add(boatTypeLabel);
            this.Controls.Add(this.boatTypeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "UpdateBoat";
            this.Text = "CreatBoatForm";
            this.Load += new System.EventHandler(this.CreatBoatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBoatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbBoatDataSet dbBoatDataSet;
        private System.Windows.Forms.BindingSource boatBindingSource;
        private DbBoatDataSetTableAdapters.BoatTableAdapter boatTableAdapter;
        private DbBoatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox boatTypeTextBox;
        private System.Windows.Forms.TextBox numberOfRowersTextBox;
        private System.Windows.Forms.CheckBox mastCheckBox;
        private System.Windows.Forms.TextBox basePriceTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}