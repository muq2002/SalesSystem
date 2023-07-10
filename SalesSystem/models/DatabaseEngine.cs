using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SalesSystem.models
{
    class DatabaseEngine
    {
        static string constr = "provider=microsoft.ace.oledb.12.0; data source=" + AppDomain.CurrentDomain.BaseDirectory + "Shopment.accdb";
        OleDbConnection dbcon = new OleDbConnection(constr);

        public void runCommand(string query)
        {
            try
            {
                OleDbCommand command = dbcon.CreateCommand();
                if (dbcon.State == ConnectionState.Closed)
                    dbcon.Open();


                command.Connection = dbcon;
                command.CommandText = query;
               
                command.ExecuteNonQuery();

                dbcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public DataTable getTable(string queryTable)
        {
            try
            {
                OleDbCommand command = dbcon.CreateCommand();
                if (dbcon.State == ConnectionState.Closed)
                    dbcon.Open();


                command.Connection = dbcon;
                command.CommandText = queryTable;

                DataTable holderTable = getHolderTable(command);

                return holderTable;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new DataTable();
            }
        }

        private static DataTable getHolderTable(OleDbCommand command)
        {
            OleDbDataAdapter adapterData = new OleDbDataAdapter(command);
            DataTable holderTable = new DataTable();
            adapterData.Fill(holderTable);
            return holderTable;
        }
    }
}

