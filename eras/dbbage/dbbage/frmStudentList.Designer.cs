namespace dbbage
{
    partial class frmStudentList
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            label8 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataList = new DataGridView();
            dBConnectBindingSource = new BindingSource(components);
            btnRefresh = new Button();
            dBConnectBindingSource1 = new BindingSource(components);
            dBConnectBindingSource2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBConnectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBConnectBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBConnectBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(487, 59);
            label1.Name = "label1";
            label1.Size = new Size(230, 19);
            label1.TabIndex = 0;
            label1.Text = "UPDATE STUDENT INFORMATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(512, 105);
            label2.Name = "label2";
            label2.Size = new Size(27, 19);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(454, 139);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(458, 171);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 3;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(478, 201);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 4;
            label5.Text = "Course:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(475, 231);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 5;
            label6.Text = "Section:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(497, 257);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 6;
            label7.Text = "Age:";
            // 
            // txtID
            // 
            txtID.Location = new Point(545, 104);
            txtID.Name = "txtID";
            txtID.Size = new Size(170, 23);
            txtID.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(545, 138);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(170, 23);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(547, 170);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(170, 23);
            txtLastName.TabIndex = 9;
            txtLastName.TextChanged += textBox3_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(545, 256);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(170, 23);
            txtAge.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ACT" });
            comboBox1.Location = new Point(545, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 23);
            comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1A", "1B", "1C", "1D", "1E", "1F" });
            comboBox2.Location = new Point(545, 229);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 23);
            comboBox2.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(545, 285);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(172, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Record";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(545, 325);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(172, 34);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete Record";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(34, 59);
            label8.Name = "label8";
            label8.Size = new Size(161, 19);
            label8.TabIndex = 15;
            label8.Text = "STUDENT MASTER LIST";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(34, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(161, 23);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(201, 101);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 23);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataList
            // 
            dataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataList.Location = new Point(34, 130);
            dataList.Name = "dataList";
            dataList.Size = new Size(400, 219);
            dataList.TabIndex = 18;
            dataList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dBConnectBindingSource
            // 
            dBConnectBindingSource.DataSource = typeof(DBConnect);
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(330, 55);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 23);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dBConnectBindingSource1
            // 
            dBConnectBindingSource1.DataSource = typeof(DBConnect);
            // 
            // dBConnectBindingSource2
            // 
            dBConnectBindingSource2.DataSource = typeof(DBConnect);
            // 
            // frmStudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(btnRefresh);
            Controls.Add(dataList);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label8);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudentList";
            Text = "frmStudentList";
            Load += frmStudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dataList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBConnectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBConnectBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBConnectBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnSave;
        private Button btnDelete;
        private Label label8;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataList;
        private Button btnRefresh;
        private BindingSource dBConnectBindingSource;
        private BindingSource dBConnectBindingSource1;
        private BindingSource dBConnectBindingSource2;
    }
}