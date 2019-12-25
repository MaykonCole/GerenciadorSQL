namespace MaykonSoft
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracaoInstanciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textServ = new System.Windows.Forms.TextBox();
            this.painel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.painel.Controls.Add(this.label3);
            this.painel.Controls.Add(this.label2);
            this.painel.Controls.Add(this.textSenha);
            this.painel.Controls.Add(this.textUser);
            this.painel.Controls.Add(this.button1);
            this.painel.Controls.Add(this.label1);
            this.painel.Controls.Add(this.textServ);
            this.painel.Location = new System.Drawing.Point(0, 27);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(710, 427);
            this.painel.TabIndex = 0;
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
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configraçãoToolStripMenuItem
            // 
            this.configraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.configraçãoToolStripMenuItem.Name = "configraçãoToolStripMenuItem";
            this.configraçãoToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.configraçãoToolStripMenuItem.Text = "Home";
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
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "SENHA";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "USUÁRIOSQL";
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(387, 172);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(113, 20);
            this.textSenha.TabIndex = 11;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(387, 137);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(113, 20);
            this.textUser.TabIndex = 10;
            this.textUser.Text = "sa";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(296, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "CONECTAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "SERVIDOR";
            // 
            // textServ
            // 
            this.textServ.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.textServ.Location = new System.Drawing.Point(387, 100);
            this.textServ.Name = "textServ";
            this.textServ.Size = new System.Drawing.Size(113, 20);
            this.textServ.TabIndex = 7;
            this.textServ.Text = "(local)\\instanciasql";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.painel);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrizaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracaoInstanciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textServ;
    }
}