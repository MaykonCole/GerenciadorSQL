namespace MaykonSoft
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExecute = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracaoInstanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.painelMenu = new System.Windows.Forms.Panel();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.painelMenu.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(437, 223);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(134, 34);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "EXECUTAR";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configraçãoToolStripMenuItem,
            this.parametrosSQLToolStripMenuItem,
            this.configuracaoInstanciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // configraçãoToolStripMenuItem
            // 
            this.configraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.configraçãoToolStripMenuItem.Name = "configraçãoToolStripMenuItem";
            this.configraçãoToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.configraçãoToolStripMenuItem.Text = "Home";
            this.configraçãoToolStripMenuItem.Click += new System.EventHandler(this.ConfigraçãoToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // parametrosSQLToolStripMenuItem
            // 
            this.parametrosSQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrizaçãoToolStripMenuItem});
            this.parametrosSQLToolStripMenuItem.Name = "parametrosSQLToolStripMenuItem";
            this.parametrosSQLToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.parametrosSQLToolStripMenuItem.Text = "Parametros SQL";
            // 
            // parametrizaçãoToolStripMenuItem
            // 
            this.parametrizaçãoToolStripMenuItem.Name = "parametrizaçãoToolStripMenuItem";
            this.parametrizaçãoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.parametrizaçãoToolStripMenuItem.Text = "Parametrização";
            this.parametrizaçãoToolStripMenuItem.Click += new System.EventHandler(this.ParametrizaçãoToolStripMenuItem_Click);
            // 
            // configuracaoInstanciaToolStripMenuItem
            // 
            this.configuracaoInstanciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem});
            this.configuracaoInstanciaToolStripMenuItem.Name = "configuracaoInstanciaToolStripMenuItem";
            this.configuracaoInstanciaToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.configuracaoInstanciaToolStripMenuItem.Text = "Configuracao Instancia";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.testeToolStripMenuItem.Text = "Servidor SQL";
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.TesteToolStripMenuItem_Click);
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.painelMenu.Controls.Add(this.menuStrip1);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelMenu.Location = new System.Drawing.Point(0, 0);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(704, 72);
            this.painelMenu.TabIndex = 0;
            this.painelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.textResult);
            this.painelPrincipal.Controls.Add(this.textQuery);
            this.painelPrincipal.Controls.Add(this.btnExecute);
            this.painelPrincipal.Location = new System.Drawing.Point(0, 68);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(847, 383);
            this.painelPrincipal.TabIndex = 1;
            // 
            // textQuery
            // 
            this.textQuery.Location = new System.Drawing.Point(332, 48);
            this.textQuery.Multiline = true;
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(335, 159);
            this.textQuery.TabIndex = 4;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(332, 275);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(335, 84);
            this.textResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.painelPrincipal);
            this.Controls.Add(this.painelMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaykonSoftware";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.painelMenu.ResumeLayout(false);
            this.painelMenu.PerformLayout();
            this.painelPrincipal.ResumeLayout(false);
            this.painelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracaoInstanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.TextBox textQuery;
    }
}

