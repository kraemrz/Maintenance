using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ezHomeMaint
{
    class UpdateSpareDataBase
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

        private string _spareArtNr = "";
        private string _spareName = "";
        private string _spareLocation = "";
        private string _spareQuantity = "";

        #endregion

        #region PROPERTIES

        public string ArtNr { get; set; } = "";
        public string Name { get; set; } = "";
        public string Location { get; set; } = "";
        public string Quantity { get; set; } = "";

        #endregion

        #region CONSTRUCTORS

        public UpdateSpareDataBase()
        {
        }

        public UpdateSpareDataBase(string myArtNr, string myName, string myLocation, string myQuantity)
        {
            _spareArtNr = myArtNr;
            _spareName = myName;
            _spareLocation = myLocation;
            _spareQuantity = myQuantity;
        }

        #endregion

        #region METHODS

        #region ADD SPARE

        // ADD SPARES TO DATABASE WITH VARIABLES FROM FORM
        public void AddSpare(string myArtNr, string myName, string myLocation, string myQuantity)
        {
            // SQL CONNECTION FOR COMMUNICATE WITH DB
            var connection = new SqlConnection(connectionString);

            // SQL QUERY TO INSERT INTO DB
            var query = "INSERT INTO spares(spareNumber,spareName,sparePlace,spareQty) VALUES(@ArtNr,@Name,@Location,@Quantity)";
            var command = new SqlCommand(query, connection);

            // SETTING VALUES TO VARIABLES
            command.Parameters.Add("@ArtNr", SqlDbType.VarChar).Value = myArtNr;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = myName;
            command.Parameters.Add("@Location", SqlDbType.VarChar).Value = myLocation;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = myQuantity;

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

        #region UPDATE QUANTITY

        //UPDATES QUANTITY FROM SHOW SPARES FORM
        public void EditQuantity(string myQuantity, string selected)
        {
            var query = "UPDATE spares SET spareQty = @newQty WHERE Id = '" + selected + "'";
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(query, connection);

            connection.Open();
            command.Parameters.AddWithValue("@newQty", myQuantity);
            command.ExecuteScalar();

            MessageBox.Show("New quantity written");
        }

        #endregion

        #region DELETE SPARE

        // DELETES SPARES FROM SELECTED ROW IN DATAGRID

        public void DeleteSpare(string selectedId)
        {
            var connection = new SqlConnection(connectionString);
            var query = "DELETE FROM spares WHERE Id='" + selectedId + "'";
            connection.Open();
            var delcmd = new SqlCommand(query, connection) { Connection = connection };
            delcmd.ExecuteNonQuery();
            connection.Close();

        }

        #endregion


        #endregion
    }
}
