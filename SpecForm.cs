using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ИЗВП4
{
    public partial class SpecForm : Form
    {
        private SqlConnection _connection;
        private SqlCommand _addSpecCommand;
        private SqlCommand _editSpecCommand;
        private bool _add;
        private int _id;

        public SpecForm(int id, string name, bool add, SqlConnection connection)
        {
            InitializeComponent();
            nameBox.Text = name;
            _id = id;
            _connection = connection;
            _add = add;
            InitializeEditSpecCommand();
            InitializeAddSpecCommand();
        }

        private void InitializeAddSpecCommand()
        {
            _addSpecCommand = new SqlCommand
            {
                Connection = _connection,
                CommandText = "sh.add_specialization",
                CommandType = CommandType.StoredProcedure
            };
            _addSpecCommand.Parameters.Add("@name", SqlDbType.NVarChar, 30);
            _addSpecCommand.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.InputOutput;
            _addSpecCommand.Parameters.Add("@message", SqlDbType.NVarChar, 100).Direction = ParameterDirection.InputOutput;
            _addSpecCommand.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.InputOutput;
        }

        private void InitializeEditSpecCommand()
        {
            _editSpecCommand = new SqlCommand
            {
                Connection = _connection,
                CommandText = "sh.update_specialization",
                CommandType = CommandType.StoredProcedure
            };
            _editSpecCommand.Parameters.Add("@id", SqlDbType.Int);
            _editSpecCommand.Parameters.Add("@name", SqlDbType.NVarChar, 30);
            _editSpecCommand.Parameters.Add("@num", SqlDbType.Int).Direction = ParameterDirection.InputOutput;
            _editSpecCommand.Parameters.Add("@message", SqlDbType.NVarChar, 100).Direction = ParameterDirection.InputOutput;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool success = true;
            if (_add)
            {
                _addSpecCommand.Parameters["@name"].Value = nameBox.Text;
                _addSpecCommand.Parameters["@num"].Value = DBNull.Value;
                _addSpecCommand.Parameters["@message"].Value = DBNull.Value;
                _addSpecCommand.Parameters["@id"].Value = DBNull.Value;
                
                System.Data.ConnectionState previousConnectionState = _addSpecCommand.Connection.State;
                if (((_addSpecCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open))
                {
                    _addSpecCommand.Connection.Open();
                }
                try
                {
                    _addSpecCommand.ExecuteNonQuery();
                    if ((Int32)(_addSpecCommand.Parameters["@num"].Value) > 0)
                    {
                        success = false;
                        MessageBox.Show((string)(_addSpecCommand.Parameters["@message"].Value), 
                            "Ошибка добавления записи", MessageBoxButtons.OK);

                    }
                }
                finally
                {
                    if ((previousConnectionState == ConnectionState.Closed))
                        _addSpecCommand.Connection.Close();
                }
            }
            else
            {

                _editSpecCommand.Parameters["@id"].Value = _id;
                _editSpecCommand.Parameters["@name"].Value = nameBox.Text;
                _editSpecCommand.Parameters["@num"].Value = DBNull.Value;
                _editSpecCommand.Parameters["@message"].Value = DBNull.Value;

                ConnectionState previousConnectionState = _editSpecCommand.Connection.State;
                if (((_editSpecCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open))
                {
                    _editSpecCommand.Connection.Open();
                }
                try
                {
                    _editSpecCommand.ExecuteNonQuery();
                    if ((Int32)(_editSpecCommand.Parameters["@num"].Value) > 0)
                    {
                        success = false;
                        MessageBox.Show((string)(_editSpecCommand.Parameters["@message"].Value),
                            "Ошибка изменения записи", MessageBoxButtons.OK);
                    }
                }
                finally
                {
                    if ((previousConnectionState == ConnectionState.Closed))
                        _editSpecCommand.Connection.Close();
                }
            }
            if (success) DialogResult = DialogResult.OK;
        }
    }
}
