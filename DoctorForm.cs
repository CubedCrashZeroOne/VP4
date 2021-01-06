using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ИЗВП4
{
    public partial class DoctorForm : Form
    {
        private SqlConnection _connection;
        private SqlCommand _addDoctorCommand;
        private SqlCommand _editDoctorCommand;
        private DoctorParams _doctorParams;

        public DoctorForm(DoctorParams doctorParams, SqlConnection connnection)
        {
            InitializeComponent();
            _doctorParams = doctorParams;
            _connection = connnection;
            nameBox.Text = _doctorParams.Name;
            surnameBox.Text = _doctorParams.Surname;
            secondNameBox.Text = _doctorParams.SecondName;
            //MessageBox.Show(specializationBindingSource.DataSource.GetType().ToString(), "ff", MessageBoxButtons.OK);
            //specComboBox.SelectedItem = specComboBox.Items.Cast<hospitalFullDataSet.specializationRow>().FirstOrDefault(n => n.id == _doctorParams.SpecializationId);
            InitializeAddDoctorCommand();
            InitializeEditDoctorCommand();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalFullDataSet.specialization". При необходимости она может быть перемещена или удалена.
            this.specializationTableAdapter.Fill(this.hospitalFullDataSet.specialization);

        }

        private void InitializeAddDoctorCommand()
        {
            _addDoctorCommand = new SqlCommand
            {
                Connection = _connection,
                CommandText = "sh.add_doctor",
                CommandType = CommandType.StoredProcedure
            };
            _addDoctorCommand.Parameters.Add("@specialization_id", SqlDbType.Int);
            _addDoctorCommand.Parameters.Add("@surname", SqlDbType.NVarChar, 25);
            _addDoctorCommand.Parameters.Add("@first_name", SqlDbType.NVarChar, 25);
            _addDoctorCommand.Parameters.Add("@second_name", SqlDbType.NVarChar, 25);
            _addDoctorCommand.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.InputOutput;
            _addDoctorCommand.Parameters.Add("@message", SqlDbType.NVarChar, 100).Direction = ParameterDirection.InputOutput;
            _addDoctorCommand.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.InputOutput;
        }

        private void InitializeEditDoctorCommand()
        {
            _editDoctorCommand = new SqlCommand
            {
                Connection = _connection,
                CommandText = "sh.update_doctor",
                CommandType = CommandType.StoredProcedure
            };
            _editDoctorCommand.Parameters.Add("@id", SqlDbType.Int);
            _editDoctorCommand.Parameters.Add("@specialization_id", SqlDbType.Int);
            _editDoctorCommand.Parameters.Add("@surname", SqlDbType.NVarChar, 25);
            _editDoctorCommand.Parameters.Add("@first_name", SqlDbType.NVarChar, 25);
            _editDoctorCommand.Parameters.Add("@second_name", SqlDbType.NVarChar, 25);
            _editDoctorCommand.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.InputOutput;
            _editDoctorCommand.Parameters.Add("@message", SqlDbType.NVarChar, 100).Direction = ParameterDirection.InputOutput;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            bool success = true;
            if (_doctorParams.Add)
            {
                _addDoctorCommand.Parameters["@specialization_id"].Value = (Int32)specComboBox.SelectedValue;
                _addDoctorCommand.Parameters["@surname"].Value = surnameBox.Text;
                _addDoctorCommand.Parameters["@first_name"].Value = nameBox.Text;
                _addDoctorCommand.Parameters["@second_name"].Value = secondNameBox.Text;
                _addDoctorCommand.Parameters["@num"].Value = DBNull.Value;
                _addDoctorCommand.Parameters["@message"].Value = DBNull.Value;
                _addDoctorCommand.Parameters["@id"].Value = DBNull.Value;

                System.Data.ConnectionState previousConnectionState = _addDoctorCommand.Connection.State;
                if (((_addDoctorCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open))
                {
                    _addDoctorCommand.Connection.Open();
                }
                try
                {
                    _addDoctorCommand.ExecuteNonQuery();
                    if ((Int32)(_addDoctorCommand.Parameters["@num"].Value) > 0)
                    {
                        success = false;
                        MessageBox.Show((string)(_addDoctorCommand.Parameters["@message"].Value),
                            "Ошибка добавления записи", MessageBoxButtons.OK);

                    }
                }
                finally
                {
                    if (previousConnectionState == ConnectionState.Closed)
                        _addDoctorCommand.Connection.Close();
                }
            }
            else
            {
                _editDoctorCommand.Parameters["@id"].Value = _doctorParams.Id;
                _editDoctorCommand.Parameters["@specialization_id"].Value = (Int32)specComboBox.SelectedValue;
                _editDoctorCommand.Parameters["@surname"].Value = surnameBox.Text;
                _editDoctorCommand.Parameters["@first_name"].Value = nameBox.Text;
                _editDoctorCommand.Parameters["@second_name"].Value = secondNameBox.Text;
                _editDoctorCommand.Parameters["@num"].Value = DBNull.Value;
                _editDoctorCommand.Parameters["@message"].Value = DBNull.Value;

                ConnectionState previousConnectionState = _editDoctorCommand.Connection.State;
                if (((_editDoctorCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open))
                {
                    _editDoctorCommand.Connection.Open();
                }
                try
                {
                    _editDoctorCommand.ExecuteNonQuery();
                    if ((Int32)(_editDoctorCommand.Parameters["@num"].Value) > 0)
                    {
                        success = false;
                        MessageBox.Show((string)(_editDoctorCommand.Parameters["@message"].Value),
                            "Ошибка изменения записи", MessageBoxButtons.OK);
                    }
                }
                finally
                {
                    if ((previousConnectionState == ConnectionState.Closed))
                        _editDoctorCommand.Connection.Close();
                }
            }
            if (success) DialogResult = DialogResult.OK;
        }


        // Allows to execute code AFTER the form and its components are done loading.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (_doctorParams.Add) return;
            Task.Factory.StartNew
            (
             () =>
             {
                 System.Threading.Thread.Sleep(50);
                 Invoke(new Action(MyCode));
             }
            );
        }

        // Changes the comboBox's default item during edit.
        private void MyCode()
        {
            foreach (var item in specComboBox.Items)
            {
                specComboBox.SelectedIndex = specComboBox.Items.IndexOf(item);
                if ((Int32)specComboBox.SelectedValue == _doctorParams.SpecializationId) break;
            }
        }
    }
    public sealed class DoctorParams
    {
        public bool Add { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public int SpecializationId { get; set; }
    }
}
