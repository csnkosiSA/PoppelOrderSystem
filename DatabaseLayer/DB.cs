using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PoppelOrderSystem.BusinessLayer
{
    public class DB
    {
        #region Variable declaration
        //private string strConn = Settings.Default.PoppelOrderSystemDataConnectionString;
        private string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\lesle\\Downloads\\PoppelOrderSystem-main (3)\\PoppelOrderSystem-main\\PoppelOrderSystemDataBase.mdf\";Integrated Security=True";
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        #endregion

        #region CRUD Enumeration
        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2
        }
        #endregion

        #region Constructor

        public DB()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);// A SqlConnection is an object, just like any other C# object
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        #region Fills dataset fresh from the db for a specific table and with a specific Query        
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }
        #endregion

        #region Update the data source 

        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                cnMain.Open();
                daMain.Update(dsMain, table);
                cnMain.Close();
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            finally
            {
            }
            return success;
        }
        #endregion

    }
}