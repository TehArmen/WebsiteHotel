namespace HomePage
{
    partial class AdminPortal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOnCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBContextBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.cardNumberDataGridViewTextBoxColumn,
            this.nameOnCardDataGridViewTextBoxColumn,
            this.cvvDataGridViewTextBoxColumn,
            this.expMonthDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.firstAddressDataGridViewTextBoxColumn,
            this.secondAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(712, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 736);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "cardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "cardNumber";
            this.cardNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            this.cardNumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // nameOnCardDataGridViewTextBoxColumn
            // 
            this.nameOnCardDataGridViewTextBoxColumn.DataPropertyName = "nameOnCard";
            this.nameOnCardDataGridViewTextBoxColumn.HeaderText = "nameOnCard";
            this.nameOnCardDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.nameOnCardDataGridViewTextBoxColumn.Name = "nameOnCardDataGridViewTextBoxColumn";
            this.nameOnCardDataGridViewTextBoxColumn.Width = 250;
            // 
            // cvvDataGridViewTextBoxColumn
            // 
            this.cvvDataGridViewTextBoxColumn.DataPropertyName = "cvv";
            this.cvvDataGridViewTextBoxColumn.HeaderText = "cvv";
            this.cvvDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.cvvDataGridViewTextBoxColumn.Name = "cvvDataGridViewTextBoxColumn";
            this.cvvDataGridViewTextBoxColumn.Width = 250;
            // 
            // expMonthDataGridViewTextBoxColumn
            // 
            this.expMonthDataGridViewTextBoxColumn.DataPropertyName = "expMonth";
            this.expMonthDataGridViewTextBoxColumn.HeaderText = "expMonth";
            this.expMonthDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.expMonthDataGridViewTextBoxColumn.Name = "expMonthDataGridViewTextBoxColumn";
            this.expMonthDataGridViewTextBoxColumn.Width = 250;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 250;
            // 
            // firstAddressDataGridViewTextBoxColumn
            // 
            this.firstAddressDataGridViewTextBoxColumn.DataPropertyName = "firstAddress";
            this.firstAddressDataGridViewTextBoxColumn.HeaderText = "firstAddress";
            this.firstAddressDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.firstAddressDataGridViewTextBoxColumn.Name = "firstAddressDataGridViewTextBoxColumn";
            this.firstAddressDataGridViewTextBoxColumn.Width = 250;
            // 
            // secondAddressDataGridViewTextBoxColumn
            // 
            this.secondAddressDataGridViewTextBoxColumn.DataPropertyName = "secondAddress";
            this.secondAddressDataGridViewTextBoxColumn.HeaderText = "secondAddress";
            this.secondAddressDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.secondAddressDataGridViewTextBoxColumn.Name = "secondAddressDataGridViewTextBoxColumn";
            this.secondAddressDataGridViewTextBoxColumn.Width = 250;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 250;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 250;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "zipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "zipCode";
            this.zipCodeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.Width = 250;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 250;
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataSource = typeof(HomePage.Models.CustomerInfo);
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataSource = typeof(HomePage.Models.CustomerInfo);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(HomePage.Models.CustomerInfo);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(HomePage.Models.CustomerInfo);
            // 
            // myDBContextBindingSource
            // 
            this.myDBContextBindingSource.DataSource = typeof(HomePage.MyDBContext);
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 1034);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPortal";
            this.Text = "AdminPortal";
            this.Load += new System.EventHandler(this.AdminPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBContextBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        public BindingSource customerBindingSource;
        private BindingSource customerBindingSource1;
        private BindingSource myDBContextBindingSource;
        private BindingSource customerBindingSource2;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameOnCardDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cvvDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expMonthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource3;
    }
}