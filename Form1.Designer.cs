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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textMB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Versao = new System.Windows.Forms.Label();
            this.textSenhaSA = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.textQuery = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textVersion = new System.Windows.Forms.TextBox();
            this.textCollation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLing = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textServ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.painelMenu.SuspendLayout();
            this.painelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(518, 227);
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
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
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
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
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
            this.painelMenu.Size = new System.Drawing.Size(763, 72);
            this.painelMenu.TabIndex = 0;
            this.painelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.textServ);
            this.painelPrincipal.Controls.Add(this.label6);
            this.painelPrincipal.Controls.Add(this.textLing);
            this.painelPrincipal.Controls.Add(this.label5);
            this.painelPrincipal.Controls.Add(this.textCollation);
            this.painelPrincipal.Controls.Add(this.label4);
            this.painelPrincipal.Controls.Add(this.textVersion);
            this.painelPrincipal.Controls.Add(this.label3);
            this.painelPrincipal.Controls.Add(this.button2);
            this.painelPrincipal.Controls.Add(this.label2);
            this.painelPrincipal.Controls.Add(this.textMB);
            this.painelPrincipal.Controls.Add(this.label1);
            this.painelPrincipal.Controls.Add(this.button1);
            this.painelPrincipal.Controls.Add(this.Versao);
            this.painelPrincipal.Controls.Add(this.textSenhaSA);
            this.painelPrincipal.Controls.Add(this.textResult);
            this.painelPrincipal.Controls.Add(this.textQuery);
            this.painelPrincipal.Controls.Add(this.btnExecute);
            this.painelPrincipal.Location = new System.Drawing.Point(0, 68);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(763, 383);
            this.painelPrincipal.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "LIMITAR MEMÓRIA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "MEMÓRIA SQL";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textMB
            // 
            this.textMB.Location = new System.Drawing.Point(100, 343);
            this.textMB.Multiline = true;
            this.textMB.Name = "textMB";
            this.textMB.Size = new System.Drawing.Size(126, 30);
            this.textMB.TabIndex = 10;
            this.textMB.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Broadway", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "PAINEL T-SQL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "REDEFINIR SENHA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Versao
            // 
            this.Versao.AutoSize = true;
            this.Versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Versao.Location = new System.Drawing.Point(12, 310);
            this.Versao.Name = "Versao";
            this.Versao.Size = new System.Drawing.Size(69, 13);
            this.Versao.TabIndex = 7;
            this.Versao.Text = "SENHA SA";
            this.Versao.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textSenhaSA
            // 
            this.textSenhaSA.Location = new System.Drawing.Point(100, 293);
            this.textSenhaSA.Multiline = true;
            this.textSenhaSA.Name = "textSenhaSA";
            this.textSenhaSA.PasswordChar = '*';
            this.textSenhaSA.Size = new System.Drawing.Size(126, 30);
            this.textSenhaSA.TabIndex = 6;
            // 
            // textResult
            // 
            this.textResult.Enabled = false;
            this.textResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textResult.Location = new System.Drawing.Point(413, 277);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(335, 84);
            this.textResult.TabIndex = 5;
            // 
            // textQuery
            // 
            this.textQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuery.Location = new System.Drawing.Point(413, 47);
            this.textQuery.Multiline = true;
            this.textQuery.Name = "textQuery";
            this.textQuery.Size = new System.Drawing.Size(338, 159);
            this.textQuery.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "VERSÃO SQL";
            // 
            // textVersion
            // 
            this.textVersion.BackColor = System.Drawing.SystemColors.Menu;
            this.textVersion.Enabled = false;
            this.textVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVersion.Location = new System.Drawing.Point(100, 35);
            this.textVersion.Multiline = true;
            this.textVersion.Name = "textVersion";
            this.textVersion.Size = new System.Drawing.Size(266, 30);
            this.textVersion.TabIndex = 14;
            // 
            // textCollation
            // 
            this.textCollation.BackColor = System.Drawing.SystemColors.Menu;
            this.textCollation.Enabled = false;
            this.textCollation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCollation.Location = new System.Drawing.Point(100, 86);
            this.textCollation.Multiline = true;
            this.textCollation.Name = "textCollation";
            this.textCollation.Size = new System.Drawing.Size(266, 30);
            this.textCollation.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "COLLATION";
            // 
            // textLing
            // 
            this.textLing.BackColor = System.Drawing.SystemColors.Menu;
            this.textLing.Enabled = false;
            this.textLing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLing.Location = new System.Drawing.Point(100, 133);
            this.textLing.Multiline = true;
            this.textLing.Name = "textLing";
            this.textLing.Size = new System.Drawing.Size(266, 30);
            this.textLing.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "LINGUAGEM";
            // 
            // textServ
            // 
            this.textServ.BackColor = System.Drawing.SystemColors.Menu;
            this.textServ.Enabled = false;
            this.textServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textServ.Location = new System.Drawing.Point(100, 176);
            this.textServ.Multiline = true;
            this.textServ.Name = "textServ";
            this.textServ.Size = new System.Drawing.Size(266, 30);
            this.textServ.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "SERVIDOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(763, 450);
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
        private System.Windows.Forms.TextBox textQuery;
        private System.Windows.Forms.Label Versao;
        public System.Windows.Forms.TextBox textSenhaSA;
        public System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textMB;
        public System.Windows.Forms.TextBox textVersion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textCollation;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textLing;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textServ;
        private System.Windows.Forms.Label label6;
    }
}

