using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibDB;

namespace Repo
{
    public partial class DBConn : FormBase
    {
        public DBConn()
        {
            InitializeComponent();
        }

        private void DBConn_Load(object sender, EventArgs e)
        {
            try
            {
                DBSqlConn.DBServer = Global_DBServer;
                DBSqlConn.DBName = Global_DBName;
                DBSqlConn.DBUser = Global_DBUser;
                DBSqlConn.DBUserPwd = Global_DBUserPwd;

                DataSet ds;
                string Query = "SELECT TOP 20 DATETIME_STAMP as Fecha, ALARM as Descripcion, NOINS as Id FROM Logs ORDER BY DATETIME_STAMP DESC;";
                ds = DBSqlConn.Exec(Query);

                dgv_meters.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                DBSqlConn.DBServer = Global_DBServer;
                DBSqlConn.DBName = Global_DBName;
                DBSqlConn.DBUser = Global_DBUser;
                DBSqlConn.DBUserPwd = Global_DBUserPwd;

                string Query = "INSERT INTO Logs ( DATETIME_STAMP, ALARM, NOINS ) VALUES ( CONVERT(datetime,'{0}',102), '{1}', '{2}' );";
                Query = string.Format(Query, "2019-08-21 08:00:01.000", "Alerta de Prueba", "00007844-3");

                DBSqlConn.Exec(Query);
                MessageBox.Show("Info: Registro Creado Correctamente");
                DBConn_Load(sender, e);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DBSqlConn.DBServer = Global_DBServer;
                DBSqlConn.DBName = Global_DBName;
                DBSqlConn.DBUser = Global_DBUser;
                DBSqlConn.DBUserPwd = Global_DBUserPwd;

                string Query = "UPDATE Logs SET ALARM='{0}' WHERE NOINS='{1}';";
                Query = string.Format(Query, "Alerta de Prueba Editada", "00007844-3");

                DBSqlConn.Exec(Query);
                MessageBox.Show("Info: Registro Modificado Correctamente");
                DBConn_Load(sender, e);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DBSqlConn.DBServer = Global_DBServer;
                DBSqlConn.DBName = Global_DBName;
                DBSqlConn.DBUser = Global_DBUser;
                DBSqlConn.DBUserPwd = Global_DBUserPwd;

                string Query = "DELETE Logs WHERE NOINS='{0}';";
                Query = string.Format(Query, "00007844-3");

                DBSqlConn.Exec(Query);
                MessageBox.Show("Info: Registro Eliminado Correctamente");
                DBConn_Load(sender, e);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }

}
