using System.Data.SqlClient;
using System.Data;
using System;

namespace CEUTEC
{
    public class ConexionSQL
    {
        // Variables locales
        SqlConnection connection;
        SqlTransaction transaction;
        SqlCommand command;
        SqlConnectionStringBuilder csb;
        string gs_server="";
        string gs_bdd="";
        string gs_usuario="";
        string gs_clave="";
        string gs_error = "";
        bool IsTrusted = false;

        public string SQLError()
        {
            return gs_error;
        }

        bool ConectarTrusted(string ps_server, string ps_bdd)
        {
            try
            {
                string ls_string = "";
                ls_string = "Server={0};Database={1};Trusted_Connection=Yes;";
                ls_string = String.Format(ls_string, ps_server, ps_bdd);

                csb = new SqlConnectionStringBuilder(ls_string);  

                connection = new SqlConnection(csb.ToString());

                try
                {
                    connection.Open();
                    command = connection.CreateCommand();
                    command.Connection = connection;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    gs_error = ex.ToString();
                    return false;
                }

                if (connection.State == System.Data.ConnectionState.Open){
                    gs_server = ps_server;
                    gs_bdd = ps_bdd;
                    gs_usuario = "";
                    gs_clave = "";

                    IsTrusted = true;
                
                    return true;
                }

                else{
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public bool Conectar(string ps_server, string ps_bdd, string ps_usuario, string ps_clave)
        {
            try
            {
                string ls_string = "";

                ls_string = "Data Source={0}; Initial Catalog={1}; User ID={2}; Password='{3}';";

                ls_string = string.Format(ls_string, ps_server, ps_bdd, ps_usuario, ps_clave);

                csb = new SqlConnectionStringBuilder(ls_string);

                connection = new SqlConnection(csb.ToString());

                try
                {
                    connection.Open();

                    command = connection.CreateCommand();
                    command.Connection = connection;

                    

                }
                catch (Exception ex)
                {
                    gs_error = ex.ToString();
                    return false;
                }

                if ((connection.State == System.Data.ConnectionState.Open))
                {
                    gs_server = ps_server;
                    gs_bdd = ps_bdd;
                    gs_usuario = ps_usuario;
                    gs_clave = ps_clave;

                    //connection.Close();

                    return true;

                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                gs_error = ex.ToString();
                return false;
            }
        }

        public bool ReConectar()
        {
            if (IsTrusted)
            {
                return ConectarTrusted(gs_server, gs_bdd);
            }
            else
            {
                return Conectar(gs_server, gs_bdd, gs_usuario, gs_clave);
            }
        }

        public void Cerrar()
        {
            if ((connection.State == ConnectionState.Open))
            {
                if ((connection.State == System.Data.ConnectionState.Open))
                {
                    connection.Close();
                }
            }

        }

        public DataSet SqlSelect(string ps_query)
        {
            DataSet ds = null;
            Int32 rows = default(Int32);
            SqlDataAdapter myDataAdapter = default(SqlDataAdapter);

            ds = new DataSet();

            ds.Clear();

            myDataAdapter = new SqlDataAdapter(ps_query, connection);

            try
            {
                rows = myDataAdapter.Fill(ds);
            }
            catch (Exception rs_exception)
            {
                gs_error = rs_exception.ToString();
            }

            return ds;

        }

        public bool SQLSelectDataSet(string ps_query, ref DataSet ds)
        {
            try
            {
                if (this.ReConectar())
                {
                    ds = this.SqlSelect(ps_query);
                    this.Cerrar();

                    if (ds.Tables.Count > 0)
                    {
                        return true;
                    }
                }

            }
            catch
            {
            }
            return false;
        }
        public bool SQLSelectDataTable(string ps_query, ref DataTable dt)
        {
            try
            {
                DataSet ds = new DataSet();
                if (this.ReConectar())
                {
                    ds = this.SqlSelect(ps_query);
                    this.Cerrar();

                    if (ds.Tables.Count > 0)
                    {
                        dt = ds.Tables[0];
                        dt.TableName = "DATOS";
                        return true;
                    }
                }

            }
            catch
            {
            }
            return false;
        }
        
        public bool SQLSelectDataRow(string ps_query, ref DataRow dr)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = null;
                if (this.ReConectar())
                {
                    ds = this.SqlSelect(ps_query);
                    this.Cerrar();

                    if (ds.Tables.Count > 0)
                    {
                        dt = ds.Tables[0];
                        if (dt.Rows.Count > 0)
                        {
                            dr = dt.Rows[0];
                            return true;
                        }
                    }
                }

            }
            catch
            {
            }
            return false;

        }

        public bool SqlExec(string query)
        {
            try
            {
                int retorno = 0;
                if (this.ReConectar())
                {
                    retorno = this.SqlExecInmediato(query);
                    this.Cerrar();

                    if (retorno != -99)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                gs_error = "Error la ejecutar cadena: " + ex.ToString();
            }
            return false;
        }

        public Int32 SqlExecInmediato(string query)
        {
            Int32 rows = default(Int32);

            rows = 0;
            command.CommandText = query;

            try
            {
                IniciarTransaccion();
                command.Transaction = transaction;
                command.Prepare();

                rows = command.ExecuteNonQuery();

                Commit();
            }
            catch (Exception rs_exception)
            {
                gs_error = rs_exception.ToString();
                rows = -99;
                RollBack();
            }

            return rows;

        }
        public void IniciarTransaccion()
        {
            transaction = connection.BeginTransaction(IsolationLevel.Serializable);
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void RollBack()
        {
            transaction.Rollback();
        }
    }
}
