namespace WindowsFormsApp1
{
    partial class CreateZaka
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
            System.Windows.Forms.Label orderLabel;
            System.Windows.Forms.Label salespersonLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label contractIDLabel;
            System.Windows.Forms.Label depositPayedLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label contractTotalPriceLabel;
            System.Windows.Forms.Label contracTotalPriceinclVATLabel;
            System.Windows.Forms.Label productionProcessLabel;
            System.Windows.Forms.Label detailIDLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbBoatDataSet = new WindowsFormsApp1.DbBoatDataSet();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.productionProcessTextBox = new System.Windows.Forms.TextBox();
            this.contracTotalPriceinclVATTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.depositPayedTextBox = new System.Windows.Forms.TextBox();
            this.contractIDTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.detailIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accessoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new WindowsFormsApp1.DbBoatDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.DbBoatDataSetTableAdapters.TableAdapterManager();
            this.boatTableAdapter = new WindowsFormsApp1.DbBoatDataSetTableAdapters.BoatTableAdapter();
            this.contractTableAdapter = new WindowsFormsApp1.DbBoatDataSetTableAdapters.ContractTableAdapter();
            this.customerTableAdapter = new WindowsFormsApp1.DbBoatDataSetTableAdapters.CustomerTableAdapter();
            this.salesPersonTableAdapter = new WindowsFormsApp1.DbBoatDataSetTableAdapters.SalesPersonTableAdapter();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.accessoryTableAdapter = new WindowsFormsApp1.DbBoatDataSetTableAdapters.AccessoryTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.orderDetailsTableAdapter1 = new WindowsFormsApp1.DbBoatDataSetTableAdapters.OrderDetailsTableAdapter();
            orderLabel = new System.Windows.Forms.Label();
            salespersonLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            contractIDLabel = new System.Windows.Forms.Label();
            depositPayedLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            contractTotalPriceLabel = new System.Windows.Forms.Label();
            contracTotalPriceinclVATLabel = new System.Windows.Forms.Label();
            productionProcessLabel = new System.Windows.Forms.Label();
            detailIDLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBoatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Location = new System.Drawing.Point(63, 18);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new System.Drawing.Size(36, 13);
            orderLabel.TabIndex = 0;
            orderLabel.Text = "Order:";
            // 
            // salespersonLabel
            // 
            salespersonLabel.AutoSize = true;
            salespersonLabel.Location = new System.Drawing.Point(31, 44);
            salespersonLabel.Name = "salespersonLabel";
            salespersonLabel.Size = new System.Drawing.Size(68, 13);
            salespersonLabel.TabIndex = 4;
            salespersonLabel.Text = "Salesperson:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Location = new System.Drawing.Point(45, 70);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(54, 13);
            customerLabel.TabIndex = 6;
            customerLabel.Text = "Customer:";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(10, 97);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(89, 13);
            deliveryAddressLabel.TabIndex = 10;
            deliveryAddressLabel.Text = "Delivery Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(72, 123);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 12;
            cityLabel.Text = "City:";
            // 
            // contractIDLabel
            // 
            contractIDLabel.AutoSize = true;
            contractIDLabel.Location = new System.Drawing.Point(83, 9);
            contractIDLabel.Name = "contractIDLabel";
            contractIDLabel.Size = new System.Drawing.Size(64, 13);
            contractIDLabel.TabIndex = 0;
            contractIDLabel.Text = "Contract ID:";
            // 
            // depositPayedLabel
            // 
            depositPayedLabel.AutoSize = true;
            depositPayedLabel.Location = new System.Drawing.Point(68, 35);
            depositPayedLabel.Name = "depositPayedLabel";
            depositPayedLabel.Size = new System.Drawing.Size(79, 13);
            depositPayedLabel.TabIndex = 2;
            depositPayedLabel.Text = "Deposit Payed:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(97, 61);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 4;
            orderIDLabel.Text = "Order ID:";
            // 
            // contractTotalPriceLabel
            // 
            contractTotalPriceLabel.AutoSize = true;
            contractTotalPriceLabel.Location = new System.Drawing.Point(16, 401);
            contractTotalPriceLabel.Name = "contractTotalPriceLabel";
            contractTotalPriceLabel.Size = new System.Drawing.Size(104, 13);
            contractTotalPriceLabel.TabIndex = 6;
            contractTotalPriceLabel.Text = "Contract Total Price:";
            // 
            // contracTotalPriceinclVATLabel
            // 
            contracTotalPriceinclVATLabel.AutoSize = true;
            contracTotalPriceinclVATLabel.Location = new System.Drawing.Point(6, 87);
            contracTotalPriceinclVATLabel.Name = "contracTotalPriceinclVATLabel";
            contracTotalPriceinclVATLabel.Size = new System.Drawing.Size(141, 13);
            contracTotalPriceinclVATLabel.TabIndex = 8;
            contracTotalPriceinclVATLabel.Text = "Contrac Total Priceincl VAT:";
            // 
            // productionProcessLabel
            // 
            productionProcessLabel.AutoSize = true;
            productionProcessLabel.Location = new System.Drawing.Point(45, 113);
            productionProcessLabel.Name = "productionProcessLabel";
            productionProcessLabel.Size = new System.Drawing.Size(102, 13);
            productionProcessLabel.TabIndex = 10;
            productionProcessLabel.Text = "Production Process:";
            // 
            // detailIDLabel
            // 
            detailIDLabel.AutoSize = true;
            detailIDLabel.Location = new System.Drawing.Point(11, 235);
            detailIDLabel.Name = "detailIDLabel";
            detailIDLabel.Size = new System.Drawing.Size(51, 13);
            detailIDLabel.TabIndex = 4;
            detailIDLabel.Text = "Detail ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.orderTextBox);
            this.tabPage1.Controls.Add(this.cityTextBox);
            this.tabPage1.Controls.Add(this.deliveryAddressTextBox);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.boatDataGridView);
            this.tabPage1.Controls.Add(this.customerDataGridView);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(cityLabel);
            this.tabPage1.Controls.Add(deliveryAddressLabel);
            this.tabPage1.Controls.Add(customerLabel);
            this.tabPage1.Controls.Add(salespersonLabel);
            this.tabPage1.Controls.Add(orderLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(105, 15);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderTextBox.TabIndex = 22;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(105, 120);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 20);
            this.cityTextBox.TabIndex = 21;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(105, 94);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(200, 20);
            this.deliveryAddressTextBox.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Цена лодок:";
            // 
            // boatDataGridView
            // 
            this.boatDataGridView.AutoGenerateColumns = false;
            this.boatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.boatDataGridView.DataSource = this.boatBindingSource;
            this.boatDataGridView.Location = new System.Drawing.Point(13, 178);
            this.boatDataGridView.Name = "boatDataGridView";
            this.boatDataGridView.Size = new System.Drawing.Size(749, 162);
            this.boatDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn2.HeaderText = "Model";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BoatType";
            this.dataGridViewTextBoxColumn3.HeaderText = "BoatType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NumberOfRowers";
            this.dataGridViewTextBoxColumn4.HeaderText = "NumberOfRowers";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Mast";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Mast";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Colour";
            this.dataGridViewTextBoxColumn5.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Wood";
            this.dataGridViewTextBoxColumn6.HeaderText = "Wood";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BasePrice";
            this.dataGridViewTextBoxColumn7.HeaderText = "BasePrice";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VAT";
            this.dataGridViewTextBoxColumn8.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // boatBindingSource
            // 
            this.boatBindingSource.DataMember = "Boat";
            this.boatBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // dbBoatDataSet
            // 
            this.dbBoatDataSet.DataSetName = "DbBoatDataSet";
            this.dbBoatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(311, 6);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(451, 166);
            this.customerDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn9.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FistName";
            this.dataGridViewTextBoxColumn10.HeaderText = "FistName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "FamilyName";
            this.dataGridViewTextBoxColumn11.HeaderText = "FamilyName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DateOfBirth";
            this.dataGridViewTextBoxColumn12.HeaderText = "DateOfBirth";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "OrganisationName";
            this.dataGridViewTextBoxColumn13.HeaderText = "OrganisationName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn14.HeaderText = "Address";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn15.HeaderText = "City";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn16.HeaderText = "email";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn17.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "IDNumber";
            this.dataGridViewTextBoxColumn18.HeaderText = "IDNumber";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "IDDocumentName";
            this.dataGridViewTextBoxColumn19.HeaderText = "IDDocumentName";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.customerBindingSource;
            this.comboBox3.DisplayMember = "Phone";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(105, 67);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 16;
            this.comboBox3.ValueMember = "CustomerID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.salesPersonBindingSource;
            this.comboBox1.DisplayMember = "FirstName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "SalesPersonID";
            // 
            // salesPersonBindingSource
            // 
            this.salesPersonBindingSource.DataMember = "SalesPerson";
            this.salesPersonBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.productionProcessTextBox);
            this.tabPage2.Controls.Add(this.contracTotalPriceinclVATTextBox);
            this.tabPage2.Controls.Add(this.orderIDTextBox);
            this.tabPage2.Controls.Add(this.depositPayedTextBox);
            this.tabPage2.Controls.Add(this.contractIDTextBox);
            this.tabPage2.Controls.Add(productionProcessLabel);
            this.tabPage2.Controls.Add(contracTotalPriceinclVATLabel);
            this.tabPage2.Controls.Add(orderIDLabel);
            this.tabPage2.Controls.Add(depositPayedLabel);
            this.tabPage2.Controls.Add(contractIDLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // productionProcessTextBox
            // 
            this.productionProcessTextBox.Location = new System.Drawing.Point(153, 110);
            this.productionProcessTextBox.Name = "productionProcessTextBox";
            this.productionProcessTextBox.ReadOnly = true;
            this.productionProcessTextBox.Size = new System.Drawing.Size(158, 20);
            this.productionProcessTextBox.TabIndex = 16;
            // 
            // contracTotalPriceinclVATTextBox
            // 
            this.contracTotalPriceinclVATTextBox.Location = new System.Drawing.Point(153, 84);
            this.contracTotalPriceinclVATTextBox.Name = "contracTotalPriceinclVATTextBox";
            this.contracTotalPriceinclVATTextBox.Size = new System.Drawing.Size(158, 20);
            this.contracTotalPriceinclVATTextBox.TabIndex = 15;
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.Location = new System.Drawing.Point(153, 58);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(158, 20);
            this.orderIDTextBox.TabIndex = 14;
            // 
            // depositPayedTextBox
            // 
            this.depositPayedTextBox.Location = new System.Drawing.Point(153, 32);
            this.depositPayedTextBox.Name = "depositPayedTextBox";
            this.depositPayedTextBox.Size = new System.Drawing.Size(158, 20);
            this.depositPayedTextBox.TabIndex = 13;
            // 
            // contractIDTextBox
            // 
            this.contractIDTextBox.Location = new System.Drawing.Point(153, 6);
            this.contractIDTextBox.Name = "contractIDTextBox";
            this.contractIDTextBox.Size = new System.Drawing.Size(158, 20);
            this.contractIDTextBox.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(detailIDLabel);
            this.tabPage3.Controls.Add(this.detailIDTextBox);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.accessoryDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Accessory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // detailIDTextBox
            // 
            this.detailIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderDetailsBindingSource, "DetailID", true));
            this.detailIDTextBox.Location = new System.Drawing.Point(68, 232);
            this.detailIDTextBox.Name = "detailIDTextBox";
            this.detailIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.detailIDTextBox.TabIndex = 5;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(248, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 81);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить аксесуар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общая цена";
            // 
            // accessoryDataGridView
            // 
            this.accessoryDataGridView.AutoGenerateColumns = false;
            this.accessoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.accessoryDataGridView.DataSource = this.accessoryBindingSource;
            this.accessoryDataGridView.Location = new System.Drawing.Point(6, 6);
            this.accessoryDataGridView.Name = "accessoryDataGridView";
            this.accessoryDataGridView.Size = new System.Drawing.Size(756, 220);
            this.accessoryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "AccessoryID";
            this.dataGridViewTextBoxColumn20.HeaderText = "AccessoryID";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "AccName";
            this.dataGridViewTextBoxColumn21.HeaderText = "AccName";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "DescriptionOfAccessory";
            this.dataGridViewTextBoxColumn22.HeaderText = "DescriptionOfAccessory";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn23.HeaderText = "Price";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "VAT";
            this.dataGridViewTextBoxColumn24.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Inventory";
            this.dataGridViewTextBoxColumn25.HeaderText = "Inventory";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "OrderLevel";
            this.dataGridViewTextBoxColumn26.HeaderText = "OrderLevel";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "OrderBatch";
            this.dataGridViewTextBoxColumn27.HeaderText = "OrderBatch";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "PartnerID";
            this.dataGridViewTextBoxColumn28.HeaderText = "PartnerID";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // accessoryBindingSource
            // 
            this.accessoryBindingSource.DataMember = "Accessory";
            this.accessoryBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessoriesToBoatTableAdapter = null;
            this.tableAdapterManager.AccessoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoatTableAdapter = this.boatTableAdapter;
            this.tableAdapterManager.ContractTableAdapter = this.contractTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.PartnerTableAdapter = null;
            this.tableAdapterManager.SalesPersonTableAdapter = this.salesPersonTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DbBoatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // boatTableAdapter
            // 
            this.boatTableAdapter.ClearBeforeFill = true;
            // 
            // contractTableAdapter
            // 
            this.contractTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.dbBoatDataSet;
            // 
            // contractTotalPriceTextBox
            // 
            this.contractTotalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractTotalPrice", true));
            this.contractTotalPriceTextBox.Location = new System.Drawing.Point(126, 398);
            this.contractTotalPriceTextBox.Name = "contractTotalPriceTextBox";
            this.contractTotalPriceTextBox.ReadOnly = true;
            this.contractTotalPriceTextBox.Size = new System.Drawing.Size(218, 20);
            this.contractTotalPriceTextBox.TabIndex = 7;
            // 
            // accessoryTableAdapter
            // 
            this.accessoryTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(615, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть договор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(350, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "Выбрать лодку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // orderDetailsTableAdapter1
            // 
            this.orderDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // CreateZaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.contractTotalPriceTextBox);
            this.Controls.Add(contractTotalPriceLabel);
            this.Name = "CreateZaka";
            this.Text = "CreateZaka";
            this.Load += new System.EventHandler(this.CreateZaka_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boatDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBoatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DbBoatDataSet dbBoatDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private DbBoatDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private DbBoatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DbBoatDataSetTableAdapters.ContractTableAdapter contractTableAdapter;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox contractTotalPriceTextBox;
        private DbBoatDataSetTableAdapters.BoatTableAdapter boatTableAdapter;
        private System.Windows.Forms.BindingSource boatBindingSource;
        private DbBoatDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private DbBoatDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridView boatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource accessoryBindingSource;
        private DbBoatDataSetTableAdapters.AccessoryTableAdapter accessoryTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView accessoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox productionProcessTextBox;
        private System.Windows.Forms.TextBox contracTotalPriceinclVATTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox depositPayedTextBox;
        private System.Windows.Forms.TextBox contractIDTextBox;
        private System.Windows.Forms.Button button3;
        private DbBoatDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter1;
        private System.Windows.Forms.TextBox detailIDTextBox;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
    }
}