using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;


namespace utilitario_sqlserver.classes
{
    class SQLServerUtils
    {

        private string database;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        private string connection;
        private string backupFile;
        
               

        public void backup(string connection, string database, string backupFile)
        {
            this.connection = connection;
            this.database = database;
            this.backupFile = backupFile;
            this.sqlConnection = new SqlConnection(this.connection);



            try
            {
                this.sqlCommand = new SqlCommand("BACKUP DATABASE [" + this.database + "] TO DISK = '" + this.backupFile + "'", this.sqlConnection);
                this.sqlConnection.Open();
                this.sqlCommand.ExecuteNonQuery();

            }
            finally
            {
                this.sqlConnection.Close();
            }


        }

        public void restore(string connection, string database, string backupFile)
        {

            this.connection = connection;
            this.database = database;
            this.backupFile = backupFile;

            this.sqlConnection = new SqlConnection(this.connection);

            try
            {

                
                this.sqlCommand = new SqlCommand("RESTORE DATABASE [" + this.database + "] FROM DISK = '" + this.backupFile + "'",this.sqlConnection);

                this.sqlConnection.Open();

                this.sqlCommand.ExecuteNonQuery();
            }
            finally
            {

                this.sqlConnection.Close();
            }

            
            this.sqlConnection.Open();

        }

        public string[] getDatabase(string database)
        {
            this.database = database;

            this.sqlConnection = new SqlConnection(this.database);

            ArrayList dbList = new ArrayList();

            this.sqlCommand = new SqlCommand("SELECT [name] from sysdatabases", this.sqlConnection);

            try { 
            this.sqlConnection.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            SqlDataReader sqlDataReader = default(SqlDataReader);

            try
            {
                sqlDataReader = this.sqlCommand.ExecuteReader(); 
              
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            while (sqlDataReader.Read())
            {
                dbList.Add(sqlDataReader["name"]);
            }

            this.sqlConnection.Close();

            return (String[])dbList.ToArray(typeof(string));


        }






    }
}
