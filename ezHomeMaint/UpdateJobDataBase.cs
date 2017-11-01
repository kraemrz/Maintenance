using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ezHomeMaint
{
    class UpdateJobDataBase
    {
        #region VARIBLES

        string connectionString = "Data Source=(localDB)\\mySQLdb;" +
                                  "Initial Catalog=ezMaintdb;" +
                                  "Integrated Security=True;" +
                                  "Connect Timeout=15;" +
                                  "Encrypt=False;" +
                                  "TrustServerCertificate=True;" +
                                  "ApplicationIntent=ReadWrite;" +
                                  "MultiSubnetFailover=False";

        private string _roomName = "";
        private string _date = "";
        private string _description = "";
        private string _status = "";

        #endregion

        #region PROPERTIES

        public string RoomName { get; set; } = "";
        public string Date { get; set; } = "";
        public string Description { get; set; } = "";
        public string Status { get; set; } = "";

        #endregion

        #region CONSTRUCTORS

        public UpdateJobDataBase()
        {
        }

        public UpdateJobDataBase(string myRoomName, string myDate, string myDescription, string myStatus)
        {
            _roomName = myRoomName;
            _date = myDate;
            _description = myDescription;
            _status = myStatus;
        }

        #endregion

        #region METHODS

        #region ADD WORK
        // THIS METHOD WILL ADD WORK TO THE DATABASE USING INPUT FROM THE FORM

        public void AddWork(string myRoomName, string myDate, string myDescription, string myStatus)
        {
            // SQL CONNECTION FOR COMMUNICATE WITH DB
            var connection = new SqlConnection(connectionString);

            // SQL QUERY TO INSERT INTO DB
            var query = "INSERT INTO work(RoomName,Date,Description,Status) VALUES(@Name,@Date,@Description,@Status)";
            var command = new SqlCommand(query, connection);

            // SETTING VALUES TO VARIABLES
            command.Parameters.Add("@Name", SqlDbType.NChar).Value = myRoomName;
            command.Parameters.Add("@Date", SqlDbType.Date).Value = myDate;
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = myDescription;
            command.Parameters.Add("@Status", SqlDbType.VarChar).Value = myStatus;

            // ADDING DATA INTO DB
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            int i = command.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Data successfully saved!");
                connection.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        #endregion

        #region UPDATE STATUS
        //THIS METHOD WILL UPDATE THE STATUS OF WORK IN PROGRESS

        public void StatusWork(string myStatus, string selected)
        {
            var query = "UPDATE work SET status = @newStatus WHERE Id = '" + selected + "'";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(query, connection);

            connection.Open();
            command.Parameters.AddWithValue("@newStatus", myStatus);
            command.ExecuteScalar();

            MessageBox.Show("Status updated");
        }
        #endregion

        #region DELETE SPARE

        // THIS METHOD WILL DELETE SELECTED WORK FROM DATABASE 

        public void DeleteJob(string selectedRowId)
        {
            var query = "DELETE FROM Work WHERE Id='" + selectedRowId + "'";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var delCmd = new SqlCommand(query, connection) { Connection = connection };
            delCmd.ExecuteNonQuery();
            connection.Close();

        }

        #endregion

        #endregion
    }
}
