using SQLServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaykonSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {

            // Cria Objeto de Conexao
            Conector con = new Conector();

            

            // Valida se foi preenchido algo no TextBox TSQL
            if (textQuery.Text.Length < 1)
            {
              
                MessageBox.Show("Não foi especificado nenhum comando no painel TSQL");
                
           
            }

            // Caso existir alguma parametro no TSQL ser executado
            else
            {
                
                string comando = textQuery.Text;

                try
                {
                  
                        con.executeQuery(".\\sqlng", "sa", "bel",comando);
                        textResult.Text = "Comando realizado com sucesso.";
                 

                }
                catch (Exception m)
                {
                    textResult.Text = m.Message;
                }
            }
           


        }

        private void ConfigraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TesteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ParametrizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // Cria o Objeto que sera exibido na tela TelaConexao
            telaConexao telcon = new telaConexao();
            telcon.TopLevel = false;
            telcon.Visible = true;
            //Parametros de posicionamento central do form Tela Conexao
            telcon.Top = 130;
            telcon.Left = 200;
            // Esconde o painel Principal
            painelPrincipal.Visible = false;
            // Adiciona no Form a nova tela TelaConexao
            this.Controls.Add(telcon);
           // this.Close();

            
            
        }
    }
}
