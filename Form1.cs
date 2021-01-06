using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ИЗВП4
{
    public partial class Form1 : Form
    {
        private SqlCommand _deleteSpecCommand;
        private SqlCommand _deleteDoctorCommand;


        public Form1()
        {
            InitializeComponent();
            InitializeSpecCommands();
            InitializeDoctorCommands();
        }

        private void InitializeSpecCommands()
        {
            _deleteSpecCommand = new SqlCommand
            {
                Connection = specializationTableAdapter1.Connection,
                CommandText = "sh.delete_specialization",
                CommandType = CommandType.StoredProcedure
            };
            _deleteSpecCommand.Parameters.Add("@id", SqlDbType.Int);
            _deleteSpecCommand.Parameters.Add("@delete_other_tables", SqlDbType.Bit);
            _deleteSpecCommand.Parameters.Add("@num", SqlDbType.Int).Direction = System.Data.ParameterDirection.InputOutput;
            _deleteSpecCommand.Parameters.Add("@message", SqlDbType.NVarChar, 100).Direction = System.Data.ParameterDirection.InputOutput;
        }

        private void InitializeDoctorCommands()
        {
            _deleteDoctorCommand = new SqlCommand
            {
                Connection = doctor_viewTableAdapter1.Connection,
                CommandText = "sh.delete_doctor",
                CommandType = CommandType.StoredProcedure
            };
            _deleteDoctorCommand.Parameters.Add("@id", SqlDbType.Int);
            _deleteDoctorCommand.Parameters.Add("@delete_other_tables", SqlDbType.Bit);
            _deleteDoctorCommand.Parameters.Add("@num", SqlDbType.Int).Direction = System.Data.ParameterDirection.InputOutput;
            _deleteDoctorCommand.Parameters.Add("@message", SqlDbType.NVarChar, 100).Direction = System.Data.ParameterDirection.InputOutput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalFullDataSet.visit_view". При необходимости она может быть перемещена или удалена.
            this.visit_viewTableAdapter1.Fill(this.hospitalFullDataSet.visit_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalFullDataSet.diagnosis". При необходимости она может быть перемещена или удалена.
            this.diagnosisTableAdapter1.Fill(this.hospitalFullDataSet.diagnosis);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalFullDataSet.doctor_view". При необходимости она может быть перемещена или удалена.
            this.doctor_viewTableAdapter1.Fill(this.hospitalFullDataSet.doctor_view);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalFullDataSet.specialization". При необходимости она может быть перемещена или удалена.
            this.specializationTableAdapter1.Fill(this.hospitalFullDataSet.specialization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalFullDataSet.patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter1.Fill(this.hospitalFullDataSet.patient);

            this.dataGridView4.Columns[0].Visible = false;
            this.dataGridView2.Columns[0].Visible = false;
        }

        private void DeleteSpecButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите удалить специализацию \"" + (string)(dataGridView2.CurrentRow.Cells[1].Value) + "\"?",
                  "Удаление", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                _deleteSpecCommand.Parameters["@id"].Value = dataGridView2.CurrentRow.Cells[0].Value;
                _deleteSpecCommand.Parameters["@delete_other_tables"].Value = 0;
                _deleteSpecCommand.Parameters["@num"].Value = DBNull.Value;
                _deleteSpecCommand.Parameters["@message"].Value = DBNull.Value;
                ConnectionState previousConnectionState = _deleteSpecCommand.Connection.State;
                if ((_deleteSpecCommand.Connection.State & ConnectionState.Open)
                        != ConnectionState.Open)
                {
                    _deleteSpecCommand.Connection.Open();
                }
                try
                {
                    _deleteSpecCommand.ExecuteNonQuery();
                    if ((int)(_deleteSpecCommand.Parameters["@num"].Value) > 0)
                    {
                        if (MessageBox.Show((string)(_deleteSpecCommand.Parameters["@message"].Value) + "\nВсе равно удалить?",
                            "Удаление из связанных таблиц", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            _deleteSpecCommand.Parameters["@delete_other_tables"].Value = 1;
                            _deleteSpecCommand.ExecuteNonQuery();
                        }
                    }
                }
                finally
                {
                    if ((previousConnectionState == System.Data.ConnectionState.Closed))
                        _deleteSpecCommand.Connection.Close();
                }
                specializationTableAdapter1.Fill(hospitalFullDataSet.specialization);
                doctor_viewTableAdapter1.Fill(hospitalFullDataSet.doctor_view);
            }

        }

        private void DeleteDoctorButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Хотите удалить врача \"" + (string)(dataGridView3.CurrentRow.Cells[0].Value) + "\"?",
                  "Удаление", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                _deleteDoctorCommand.Parameters["@id"].Value = dataGridView3.CurrentRow.Cells[5].Value;
                _deleteDoctorCommand.Parameters["@delete_other_tables"].Value = 0;
                _deleteDoctorCommand.Parameters["@num"].Value = DBNull.Value;
                _deleteDoctorCommand.Parameters["@message"].Value = DBNull.Value;
                ConnectionState previousConnectionState = _deleteDoctorCommand.Connection.State;
                if ((_deleteDoctorCommand.Connection.State & ConnectionState.Open)
                        != ConnectionState.Open)
                {
                    _deleteDoctorCommand.Connection.Open();
                }
                try
                {
                    _deleteDoctorCommand.ExecuteNonQuery();
                    if ((int)(_deleteDoctorCommand.Parameters["@num"].Value) > 0)
                    {
                        if (MessageBox.Show((string)(_deleteDoctorCommand.Parameters["@message"].Value) + "\nВсе равно удалить?",
                            "Удаление из связанных таблиц", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                        {
                            _deleteDoctorCommand.Parameters["@delete_other_tables"].Value = 1;
                            _deleteDoctorCommand.ExecuteNonQuery();
                        }
                    }
                }
                finally
                {
                    if ((previousConnectionState == System.Data.ConnectionState.Closed))
                        _deleteDoctorCommand.Connection.Close();
                }
                doctor_viewTableAdapter1.Fill(hospitalFullDataSet.doctor_view);
                visit_viewTableAdapter1.Fill(hospitalFullDataSet.visit_view);
            }
        }

        private void AddSpecButton_Click(object sender, EventArgs e)
        {
            Form AddSpecForm = new SpecForm(0, String.Empty,
                true, specializationTableAdapter1.Connection);
            if(AddSpecForm.ShowDialog() == DialogResult.OK)
            {
                specializationTableAdapter1.Fill(hospitalFullDataSet.specialization);
            }
        }

        private void EditSpecButton_Click(object sender, EventArgs e)
        {
            Form EditSpecForm = new SpecForm((int)dataGridView2.CurrentRow.Cells[0].Value, (string)dataGridView2.CurrentRow.Cells[1].Value,
                false, specializationTableAdapter1.Connection);
            if (EditSpecForm.ShowDialog() == DialogResult.OK)
            {
                specializationTableAdapter1.Fill(hospitalFullDataSet.specialization);
                doctor_viewTableAdapter1.Fill(hospitalFullDataSet.doctor_view);
                visit_viewTableAdapter1.Fill(hospitalFullDataSet.visit_view);
            }
        }

        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            Form AddDoctorForm = new DoctorForm(
                new DoctorParams
                {
                    Id = -1,
                    Add = true,
                    Name = String.Empty,
                    Surname = String.Empty,
                    SecondName = String.Empty,
                    SpecializationId = 0
                },
                doctor_viewTableAdapter1.Connection);
            if (AddDoctorForm.ShowDialog() == DialogResult.OK)
            {
                doctor_viewTableAdapter1.Fill(hospitalFullDataSet.doctor_view);
            }
        }

        private void EditDoctorButton_Click(object sender, EventArgs e)
        {
            Form AddDoctorForm = new DoctorForm(
                new DoctorParams
                {
                    Id = (Int32)dataGridView3.CurrentRow.Cells[5].Value,
                    Add = false,
                    Name = dataGridView3.CurrentRow.Cells[1].Value.ToString(),
                    Surname = dataGridView3.CurrentRow.Cells[0].Value.ToString(),
                    SecondName = dataGridView3.CurrentRow.Cells[2].Value.ToString(),
                    SpecializationId = (Int32)dataGridView3.CurrentRow.Cells[6].Value
                },
                doctor_viewTableAdapter1.Connection);
            if (AddDoctorForm.ShowDialog() == DialogResult.OK)
            {
                doctor_viewTableAdapter1.Fill(hospitalFullDataSet.doctor_view);
                visit_viewTableAdapter1.Fill(hospitalFullDataSet.visit_view);
            }
        }
    }
}
