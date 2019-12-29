using System;
using System.Collections.Generic;
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



        public string Conection(string serv, string user, string senha)
        {
            con.ConnectionString = "Data Source=" + serv + ";Initial Catalog=ng;User ID=" + user + ";Password=" + senha + "";

            try
            {
                con.Open();
                return "sim";

            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "nao";
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

            //MessageBox.Show((string)reader.GetSqlString(0));

        }
    }
        
    }
