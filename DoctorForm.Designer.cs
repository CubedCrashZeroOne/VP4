namespace ИЗВП4
{
    partial class DoctorForm
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
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.specComboBox = new System.Windows.Forms.ComboBox();
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalFullDataSet = new ИЗВП4.hospitalFullDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondNameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.specializationTableAdapter = new ИЗВП4.hospitalFullDataSetTableAdapters.specializationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalFullDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(121, 30);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(138, 20);
            this.surnameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // specComboBox
            // 
            this.specComboBox.DataSource = this.specializationBindingSource;
            this.specComboBox.DisplayMember = "name";
            this.specComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specComboBox.FormattingEnabled = true;
            this.specComboBox.Location = new System.Drawing.Point(137, 150);
            this.specComboBox.Name = "specComboBox";
            this.specComboBox.Size = new System.Drawing.Size(122, 21);
            this.specComboBox.TabIndex = 2;
            this.specComboBox.ValueMember = "id";
            // 
            // specializationBindingSource
            // 
            this.specializationBindingSource.DataMember = "specialization";
            this.specializationBindingSource.DataSource = this.hospitalFullDataSet;
            // 
            // hospitalFullDataSet
            // 
            this.hospitalFullDataSet.DataSetName = "hospitalFullDataSet";
            this.hospitalFullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Специализация";
            // 
            // secondNameBox
            // 
            this.secondNameBox.Location = new System.Drawing.Point(121, 110);
            this.secondNameBox.Name = "secondNameBox";
            this.secondNameBox.Size = new System.Drawing.Size(138, 20);
            this.secondNameBox.TabIndex = 6;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(121, 70);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(138, 20);
            this.nameBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(168, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // specializationTableAdapter
            // 
            this.specializationTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 254);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.secondNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.specComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surnameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Врач";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalFullDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox specComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secondNameBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private hospitalFullDataSet hospitalFullDataSet;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private hospitalFullDataSetTableAdapters.specializationTableAdapter specializationTableAdapter;
    }
}