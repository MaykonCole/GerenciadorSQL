﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaykonSoft;
using SQLServer;

namespace MaykonSoft
{
    public partial class telaConexao : Form
    {
        public telaConexao()
        {
            InitializeComponent();




        }



        private void TelaConexao_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextUser_TextChanged(object sender, EventArgs e)
        {

        }

       /* public ParametrosSQL ParSQL()
       {
            ParametrosSQL p = new ParametrosSQL();

           p.Servidor = "";
          p.User = "";
            p.Senha = "";
         p.Servidor = textServ.Text;
           p.User = textUser.Text;
          p.Senha = textSenha.Text;
           return p;

            }*/



            // private readonly string string_conexao = "Data Source=.\\sqlng;Initial Catalog=ng;User ID=sa;Password=ng@mastermaq2010";
            private void Button1_Click(object sender, EventArgs e)
            {

                // Cria objeto que possui as classes de Conexao
                Conector j = new Conector();
                // Cria recurso para conexao ao banco SQL
                //SqlConnection conexao = new SqlConnection();

                ParametrosSQL y = new ParametrosSQL();

            string serv = textServ.Text;
            string sen = textSenha.Text;
            string us = textUser.Text;




                // String de Conexao de acordo os valores dos atributos do objeto Parametro
                string result = j.testeConexao(serv,us,sen);




                // Valida se a Conexão foi realizada com sucesso
                if (result.Equals("sim"))
                {
                    // Oculta o Form TelaConexao
                    this.Visible = false;
                    // Cria o Forma que será visualizado
                    Form1 meu_segundo_form = new Form1();
                    // Comando para exibir na tela o Form criado acima

                    meu_segundo_form.ShowDialog();


                }




            }


        }
    }
      

        
    
