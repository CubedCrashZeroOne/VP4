namespace ИЗВП4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PatientPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalFullDataSet = new ИЗВП4.hospitalFullDataSet();
            this.SpecializationPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddSpecButton = new System.Windows.Forms.Button();
            this.DeleteSpecButton = new System.Windows.Forms.Button();
            this.EditSpecButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DoctorPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddDoctorButton = new System.Windows.Forms.Button();
            this.DeleteDoctorButton = new System.Windows.Forms.Button();
            this.EditDoctorButton = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DiagnosisPage = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.VisitPage = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitviewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter1 = new ИЗВП4.hospitalFullDataSetTableAdapters.patientTableAdapter();
            this.specializationTableAdapter1 = new ИЗВП4.hospitalFullDataSetTableAdapters.specializationTableAdapter();
            this.doctor_viewTableAdapter1 = new ИЗВП4.hospitalFullDataSetTableAdapters.doctor_viewTableAdapter();
            this.diagnosisTableAdapter1 = new ИЗВП4.hospitalFullDataSetTableAdapters.diagnosisTableAdapter();
            this.visit_viewTableAdapter1 = new ИЗВП4.hospitalFullDataSetTableAdapters.visit_viewTableAdapter();
            this.visitviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.PatientPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalFullDataSet)).BeginInit();
            this.SpecializationPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource1)).BeginInit();
            this.DoctorPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorviewBindingSource1)).BeginInit();
            this.DiagnosisPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource1)).BeginInit();
            this.VisitPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitviewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.PatientPage);
            this.tabControl1.Controls.Add(this.SpecializationPage);
            this.tabControl1.Controls.Add(this.DoctorPage);
            this.tabControl1.Controls.Add(this.DiagnosisPage);
            this.tabControl1.Controls.Add(this.VisitPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // PatientPage
            // 
            this.PatientPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PatientPage.Controls.Add(this.dataGridView1);
            this.PatientPage.ForeColor = System.Drawing.SystemColors.Control;
            this.PatientPage.Location = new System.Drawing.Point(4, 22);
            this.PatientPage.Name = "PatientPage";
            this.PatientPage.Padding = new System.Windows.Forms.Padding(3);
            this.PatientPage.Size = new System.Drawing.Size(768, 400);
            this.PatientPage.TabIndex = 0;
            this.PatientPage.Text = "Пациенты";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.secondnameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(756, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondnameDataGridViewTextBoxColumn
            // 
            this.secondnameDataGridViewTextBoxColumn.DataPropertyName = "second_name";
            this.secondnameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.secondnameDataGridViewTextBoxColumn.Name = "secondnameDataGridViewTextBoxColumn";
            this.secondnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "birth_date";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "patient";
            this.patientBindingSource1.DataSource = this.hospitalFullDataSet;
            // 
            // hospitalFullDataSet
            // 
            this.hospitalFullDataSet.DataSetName = "hospitalFullDataSet";
            this.hospitalFullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SpecializationPage
            // 
            this.SpecializationPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SpecializationPage.Controls.Add(this.panel2);
            this.SpecializationPage.Controls.Add(this.dataGridView2);
            this.SpecializationPage.ForeColor = System.Drawing.SystemColors.Control;
            this.SpecializationPage.Location = new System.Drawing.Point(4, 22);
            this.SpecializationPage.Name = "SpecializationPage";
            this.SpecializationPage.Padding = new System.Windows.Forms.Padding(3);
            this.SpecializationPage.Size = new System.Drawing.Size(768, 400);
            this.SpecializationPage.TabIndex = 1;
            this.SpecializationPage.Text = "Специализации врачей";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.AddSpecButton);
            this.panel2.Controls.Add(this.DeleteSpecButton);
            this.panel2.Controls.Add(this.EditSpecButton);
            this.panel2.Location = new System.Drawing.Point(6, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 49);
            this.panel2.TabIndex = 4;
            // 
            // AddSpecButton
            // 
            this.AddSpecButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddSpecButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddSpecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSpecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSpecButton.Location = new System.Drawing.Point(83, 12);
            this.AddSpecButton.Name = "AddSpecButton";
            this.AddSpecButton.Size = new System.Drawing.Size(128, 28);
            this.AddSpecButton.TabIndex = 1;
            this.AddSpecButton.Text = "Добавить";
            this.AddSpecButton.UseVisualStyleBackColor = false;
            this.AddSpecButton.Click += new System.EventHandler(this.AddSpecButton_Click);
            // 
            // DeleteSpecButton
            // 
            this.DeleteSpecButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteSpecButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeleteSpecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSpecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSpecButton.Location = new System.Drawing.Point(547, 12);
            this.DeleteSpecButton.Name = "DeleteSpecButton";
            this.DeleteSpecButton.Size = new System.Drawing.Size(128, 28);
            this.DeleteSpecButton.TabIndex = 3;
            this.DeleteSpecButton.Text = "Удалить";
            this.DeleteSpecButton.UseVisualStyleBackColor = false;
            this.DeleteSpecButton.Click += new System.EventHandler(this.DeleteSpecButton_Click);
            // 
            // EditSpecButton
            // 
            this.EditSpecButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditSpecButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EditSpecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditSpecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSpecButton.Location = new System.Drawing.Point(312, 12);
            this.EditSpecButton.Name = "EditSpecButton";
            this.EditSpecButton.Size = new System.Drawing.Size(128, 28);
            this.EditSpecButton.TabIndex = 2;
            this.EditSpecButton.Text = "Изменить";
            this.EditSpecButton.UseVisualStyleBackColor = false;
            this.EditSpecButton.Click += new System.EventHandler(this.EditSpecButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.specializationBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(756, 333);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specializationBindingSource1
            // 
            this.specializationBindingSource1.DataMember = "specialization";
            this.specializationBindingSource1.DataSource = this.hospitalFullDataSet;
            // 
            // DoctorPage
            // 
            this.DoctorPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DoctorPage.Controls.Add(this.panel1);
            this.DoctorPage.Controls.Add(this.dataGridView3);
            this.DoctorPage.ForeColor = System.Drawing.SystemColors.Control;
            this.DoctorPage.Location = new System.Drawing.Point(4, 22);
            this.DoctorPage.Name = "DoctorPage";
            this.DoctorPage.Size = new System.Drawing.Size(768, 400);
            this.DoctorPage.TabIndex = 2;
            this.DoctorPage.Text = "Врачи";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.AddDoctorButton);
            this.panel1.Controls.Add(this.DeleteDoctorButton);
            this.panel1.Controls.Add(this.EditDoctorButton);
            this.panel1.Location = new System.Drawing.Point(6, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 52);
            this.panel1.TabIndex = 4;
            // 
            // AddDoctorButton
            // 
            this.AddDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDoctorButton.Location = new System.Drawing.Point(83, 12);
            this.AddDoctorButton.Name = "AddDoctorButton";
            this.AddDoctorButton.Size = new System.Drawing.Size(128, 28);
            this.AddDoctorButton.TabIndex = 1;
            this.AddDoctorButton.Text = "Добавить";
            this.AddDoctorButton.UseVisualStyleBackColor = false;
            this.AddDoctorButton.Click += new System.EventHandler(this.AddDoctorButton_Click);
            // 
            // DeleteDoctorButton
            // 
            this.DeleteDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeleteDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDoctorButton.Location = new System.Drawing.Point(547, 12);
            this.DeleteDoctorButton.Name = "DeleteDoctorButton";
            this.DeleteDoctorButton.Size = new System.Drawing.Size(128, 28);
            this.DeleteDoctorButton.TabIndex = 3;
            this.DeleteDoctorButton.Text = "Удалить";
            this.DeleteDoctorButton.UseVisualStyleBackColor = false;
            this.DeleteDoctorButton.Click += new System.EventHandler(this.DeleteDoctorButton_Click);
            // 
            // EditDoctorButton
            // 
            this.EditDoctorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EditDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditDoctorButton.Location = new System.Drawing.Point(312, 12);
            this.EditDoctorButton.Name = "EditDoctorButton";
            this.EditDoctorButton.Size = new System.Drawing.Size(128, 28);
            this.EditDoctorButton.TabIndex = 2;
            this.EditDoctorButton.Text = "Изменить";
            this.EditDoctorButton.UseVisualStyleBackColor = false;
            this.EditDoctorButton.Click += new System.EventHandler(this.EditDoctorButton_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn1,
            this.firstnameDataGridViewTextBoxColumn1,
            this.secondnameDataGridViewTextBoxColumn1,
            this.specializationDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn2,
            this.specializationidDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.doctorviewBindingSource1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(756, 333);
            this.dataGridView3.TabIndex = 0;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn1
            // 
            this.firstnameDataGridViewTextBoxColumn1.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn1.Name = "firstnameDataGridViewTextBoxColumn1";
            this.firstnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // secondnameDataGridViewTextBoxColumn1
            // 
            this.secondnameDataGridViewTextBoxColumn1.DataPropertyName = "second_name";
            this.secondnameDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.secondnameDataGridViewTextBoxColumn1.Name = "secondnameDataGridViewTextBoxColumn1";
            this.secondnameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Специализация";
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // specializationidDataGridViewTextBoxColumn
            // 
            this.specializationidDataGridViewTextBoxColumn.DataPropertyName = "specialization_id";
            this.specializationidDataGridViewTextBoxColumn.HeaderText = "specialization_id";
            this.specializationidDataGridViewTextBoxColumn.Name = "specializationidDataGridViewTextBoxColumn";
            this.specializationidDataGridViewTextBoxColumn.ReadOnly = true;
            this.specializationidDataGridViewTextBoxColumn.Visible = false;
            // 
            // doctorviewBindingSource1
            // 
            this.doctorviewBindingSource1.DataMember = "doctor_view";
            this.doctorviewBindingSource1.DataSource = this.hospitalFullDataSet;
            // 
            // DiagnosisPage
            // 
            this.DiagnosisPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DiagnosisPage.Controls.Add(this.dataGridView4);
            this.DiagnosisPage.ForeColor = System.Drawing.SystemColors.Control;
            this.DiagnosisPage.Location = new System.Drawing.Point(4, 22);
            this.DiagnosisPage.Name = "DiagnosisPage";
            this.DiagnosisPage.Size = new System.Drawing.Size(768, 400);
            this.DiagnosisPage.TabIndex = 3;
            this.DiagnosisPage.Text = "Диагнозы";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.diagnosisBindingSource1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(756, 388);
            this.dataGridView4.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // diagnosisBindingSource1
            // 
            this.diagnosisBindingSource1.DataMember = "diagnosis";
            this.diagnosisBindingSource1.DataSource = this.hospitalFullDataSet;
            // 
            // VisitPage
            // 
            this.VisitPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.VisitPage.Controls.Add(this.dataGridView5);
            this.VisitPage.ForeColor = System.Drawing.SystemColors.Control;
            this.VisitPage.Location = new System.Drawing.Point(4, 22);
            this.VisitPage.Name = "VisitPage";
            this.VisitPage.Size = new System.Drawing.Size(768, 400);
            this.VisitPage.TabIndex = 4;
            this.VisitPage.Text = "Визиты";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView5.DataSource = this.visitviewBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(756, 388);
            this.dataGridView5.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Пациент";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DoctorName";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Врач";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Diagnosis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Диагноз";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VisitDate";
            this.dataGridViewTextBoxColumn4.FillWeight = 75F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VisitTime";
            this.dataGridViewTextBoxColumn5.FillWeight = 75F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Время";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SickLeave";
            this.dataGridViewTextBoxColumn6.FillWeight = 75F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Больничный";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // visitviewBindingSource1
            // 
            this.visitviewBindingSource1.DataMember = "visit_view";
            this.visitviewBindingSource1.DataSource = this.hospitalFullDataSet;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // specializationTableAdapter1
            // 
            this.specializationTableAdapter1.ClearBeforeFill = true;
            // 
            // doctor_viewTableAdapter1
            // 
            this.doctor_viewTableAdapter1.ClearBeforeFill = true;
            // 
            // diagnosisTableAdapter1
            // 
            this.diagnosisTableAdapter1.ClearBeforeFill = true;
            // 
            // visit_viewTableAdapter1
            // 
            this.visit_viewTableAdapter1.ClearBeforeFill = true;
            // 
            // visitviewBindingSource
            // 
            this.visitviewBindingSource.DataMember = "visit_view";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "patient";
            // 
            // specializationBindingSource
            // 
            this.specializationBindingSource.DataMember = "specialization";
            // 
            // doctorviewBindingSource
            // 
            this.doctorviewBindingSource.DataMember = "doctor_view";
            // 
            // diagnosisBindingSource
            // 
            this.diagnosisBindingSource.DataMember = "diagnosis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Инструментальные Средства Визуального Программирования";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.PatientPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalFullDataSet)).EndInit();
            this.SpecializationPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource1)).EndInit();
            this.DoctorPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorviewBindingSource1)).EndInit();
            this.DiagnosisPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource1)).EndInit();
            this.VisitPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitviewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PatientPage;
        private System.Windows.Forms.TabPage SpecializationPage;
        private System.Windows.Forms.TabPage DoctorPage;
        private System.Windows.Forms.TabPage DiagnosisPage;
        private System.Windows.Forms.TabPage VisitPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource doctorviewBindingSource;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource diagnosisBindingSource;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource visitviewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn visittimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sickleaveDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button DeleteSpecButton;
        private System.Windows.Forms.Button EditSpecButton;
        private System.Windows.Forms.Button AddSpecButton;
        private hospitalFullDataSet hospitalFullDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private hospitalFullDataSetTableAdapters.patientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource specializationBindingSource1;
        private hospitalFullDataSetTableAdapters.specializationTableAdapter specializationTableAdapter1;
        private System.Windows.Forms.BindingSource doctorviewBindingSource1;
        private hospitalFullDataSetTableAdapters.doctor_viewTableAdapter doctor_viewTableAdapter1;
        private System.Windows.Forms.BindingSource diagnosisBindingSource1;
        private hospitalFullDataSetTableAdapters.diagnosisTableAdapter diagnosisTableAdapter1;
        private System.Windows.Forms.BindingSource visitviewBindingSource1;
        private hospitalFullDataSetTableAdapters.visit_viewTableAdapter visit_viewTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddDoctorButton;
        private System.Windows.Forms.Button DeleteDoctorButton;
        private System.Windows.Forms.Button EditDoctorButton;
        private System.Windows.Forms.Panel panel2;
    }
}

