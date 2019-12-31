using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaykonSoft
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();


        public class Session
        {
            internal static string _connection = string.Empty;

            public static string ConnectionString
            {
                get
                {
                    if (string.IsNullOrEmpty(_connection))
                        _connection = "Data Source=.\\sqlng;Initial Catalog=ng;User ID=sa;Password=bel";
                    return _connection;
                }
            }
        }

        public class UtilBD
        {
            public static DbConnection Connect(string connectionString)
            {
                var oConn = new SqlConnection("Data Source=.\\sqlng;Initial Catalog=ng;User ID=sa;Password=bel");
                oConn.Open();
                return oConn;
            }
        }

            public SqlConnection Conection(string serv, string user, string senha)
        {

            desconectar();
            con.ConnectionString = "Data Source=" + serv + ";Initial Catalog=ng;User ID=" + user + ";Password=" + senha + "";

            try
            {
                con.Open();
               
                return con;

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

        // um método com exemplo de conexão e execução
        public string ExecutarComandoSQL(String s)
        {

          
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = s;
           var oConn = Conection(".\\sqlng", "sa", "bel") ;
                cmd.Connection = oConn;
          
            String result = (string)cmd.ExecuteScalar();

            //MessageBox.Show(result);
            
            return result;

        }

        public void executeQuery(String s)
        {

            SqlCommand comando = new SqlCommand();
            SqlConnection con = new SqlConnection();
            Conexao c = new Conexao();
            Form1 f = new Form1();



            con.ConnectionString = "Data Source=.\\sqlng;Initial Catalog=ng;User ID=sa;Password=bel";


            con.Open();



            comando.CommandText = s;

            comando.Connection = con;



            SqlDataReader reader = comando.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    MessageBox.Show(",","");
                }
            }


            finally
            {
                // Fecha o datareader
                if (reader != null)
                {
                    reader.Close();
                }

                // Fecha a conexão
                if (con != null)
                {
                    con.Close();
                }
            }


        }
    }
        
    }
