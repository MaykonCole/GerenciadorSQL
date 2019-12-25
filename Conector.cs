using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using MaykonSoft;
using System.Windows.Forms;

namespace SQLServer
{
    class Conector
    {


   

        public void executeQuery(String serv, String user, String senha,String s)
        {
         
            SqlCommand comando = new SqlCommand();
            SqlConnection con= new SqlConnection();


            

            con.ConnectionString = "Data Source=" + serv + ";Initial Catalog=ng;User ID=" + user + ";Password=" + senha + "";

            con.Open();



            comando.CommandText = s;
            comando.Connection = con;

            SqlDataReader reader = comando.ExecuteReader();





        }


        public string testeConexao(String serv, String user, String senha)
        {

            SqlConnection con = new SqlConnection();
            telaConexao t = new telaConexao();

           // ParametrosSQL y = t.ParSQL();


               con.ConnectionString = "Data Source="+serv+";Initial Catalog=ng;User ID="+user+";Password="+senha+"";
         

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


    }
}


