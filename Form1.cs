using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MaykonSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
            
        
            
    
    }

        public void executaComando(string c)
        {
            Conexao con = new Conexao();


            
            


                string comando = c;
            

                try
                {

                    con.executeQuery(comando);
                    textResult.Text = "Comando executado com sucesso!";



                }
                catch (Exception m)
                {
                    textResult.Text = m.Message;
                }
            
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
            if (textQuery.Text.Length < 1)
            {

                MessageBox.Show("Não foi especificado a nova senha do usuário SA!");


            }

            else
            {
                executaComando(textQuery.Text);

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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Valida se foi preenchido 
            if (textSenhaSA.Text.Length < 1)
            {

                MessageBox.Show("Não foi especificado a nova senha do usuário SA!");


            }

            else
            {


                executaComando("USE[master] " + "\n" +

                            "ALTER LOGIN[sa] WITH PASSWORD = N'" + textSenhaSA.Text + "'" + "\n");
            }
    }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            textMB.Text = Regex.Replace(textMB.Text, "[^0-9]", "");
            // Valida se foi preenchido 
            if (textMB.Text.Length < 1)
            {

                MessageBox.Show("Não foi especificado nenhum valor númerico!");


            }

            else
            {


                executaComando("EXEC sys.sp_configure N'show advanced options', N'1'  RECONFIGURE WITH OVERRIDE" + "\n" +

                    "EXEC sys.sp_configure N'max server memory (MB)', N'"+textMB.Text+"'" + "\n" +

                    "EXEC sys.sp_configure N'show advanced options', N'1'  RECONFIGURE WITH OVERRIDE" + "\n" );
            }
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
