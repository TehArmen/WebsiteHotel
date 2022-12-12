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
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDBContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardNumberDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(287, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(417, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "cardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "cardNumber";
            this.cardNumberDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            this.cardNumberDataGridViewTextBoxColumn.Width = 99;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "zipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "zipCode";
            this.zipCodeDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.Width = 75;
            // 
            // customerBindingSource3
            // 
            //this.customerBindingSource3.DataSource = typeof(Form1.Models.CustomerInfo);
            // 
            // customerBindingSource2
            // 
            //this.customerBindingSource2.DataSource = typeof(Form1.Models.CustomerInfo);
            // 
            // customerBindingSource1
            // 
            //this.customerBindingSource1.DataSource = typeof(Form1.Models.CustomerInfo);
            // 
            // customerBindingSource
            // 
            //this.customerBindingSource.DataSource = typeof(Form1.Models.CustomerInfo);
            // 
            // myDBContextBindingSource
            // 
            //this.myDBContextBindingSource.DataSource = typeof(Form1.MyDBContext);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Customers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Rooms";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "View Reservations";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(747, 378);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}