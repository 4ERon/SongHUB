using System.Data;
using System;
using System.Data.SqlClient;

namespace SongHUB.Data
{
    static class Registration
    {

        #region Declarations...            
        public static string ConnectionString = @"Server=4ERON\DEVDATA;Database=SongHubDB;User Id=sa;Password=ronel@123;TrustServerCertificate=True;";
        #endregion       

        #region Functions...      
        public static bool GetBoolean(string myQuery)
        {
            bool retVal = false;
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();

                    SqlDataReader myReader;
                    SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
                    myCommand.CommandTimeout = 0;
                    myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    if (myReader.HasRows)
                    {
                        retVal = true;
                    }

                    myCommand.Dispose();
                    myReader.Close();
                }
            }
            catch (Exception) { }
            return retVal;
        }

        public static DataTable Table(string myQuery)
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();

                    SqlDataReader myReader;
                    SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
                    myCommand.CommandTimeout = 0;
                    myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                    if (myReader.HasRows)
                    {
                        table.Load(myReader);
                    }

                    myCommand.Dispose();
                    myReader.Close();
                }
            }
            catch (Exception) { }
            return table;
        }
        #endregion

        #region Methods...
        public static void Execute(string myQuery)
        {
            try
            {
                using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                {
                    myConnection.Open();

                    SqlCommand myCommand = new SqlCommand(myQuery, myConnection);
                    myCommand.CommandTimeout = 0;
                    myCommand.ExecuteNonQuery();
                    myCommand.Dispose();
                }
            }
            catch (Exception) { }
        }
        #endregion
    }
}



