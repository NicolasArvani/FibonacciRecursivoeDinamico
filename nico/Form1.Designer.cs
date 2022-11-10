namespace nico
{
    partial class Fibonacci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fibonacci));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInputFibonacci = new System.Windows.Forms.TextBox();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zerarListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRodar = new System.Windows.Forms.Button();
            this.chkRecursivo = new System.Windows.Forms.CheckBox();
            this.chkDinamico = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(238, 62);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(461, 376);
            this.txtOutput.TabIndex = 1;
            // 
            // txtInputFibonacci
            // 
            this.txtInputFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtInputFibonacci.Location = new System.Drawing.Point(10, 342);
            this.txtInputFibonacci.Name = "txtInputFibonacci";
            this.txtInputFibonacci.Size = new System.Drawing.Size(222, 31);
            this.txtInputFibonacci.TabIndex = 2;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(157, 414);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(75, 24);
            this.btnMostrarLista.TabIndex = 7;
            this.btnMostrarLista.Text = "Mostrar Lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(624, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarListaToolStripMenuItem,
            this.zerarListaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarListaToolStripMenuItem
            // 
            this.salvarListaToolStripMenuItem.Name = "salvarListaToolStripMenuItem";
            this.salvarListaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.salvarListaToolStripMenuItem.Text = "Exportar Lista";
            this.salvarListaToolStripMenuItem.Click += new System.EventHandler(this.salvarListaToolStripMenuItem_Click);
            // 
            // zerarListaToolStripMenuItem
            // 
            this.zerarListaToolStripMenuItem.Name = "zerarListaToolStripMenuItem";
            this.zerarListaToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.zerarListaToolStripMenuItem.Text = "Zerar Lista";
            this.zerarListaToolStripMenuItem.Click += new System.EventHandler(this.zerarListaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integrantesToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // integrantesToolStripMenuItem
            // 
            this.integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            this.integrantesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.integrantesToolStripMenuItem.Text = "Integrantes";
            this.integrantesToolStripMenuItem.Click += new System.EventHandler(this.integrantesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ciência da\r\nComputação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(7, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Número:";
            // 
            // btnRodar
            // 
            this.btnRodar.Location = new System.Drawing.Point(157, 385);
            this.btnRodar.Name = "btnRodar";
            this.btnRodar.Size = new System.Drawing.Size(75, 23);
            this.btnRodar.TabIndex = 13;
            this.btnRodar.Text = "Rodar";
            this.btnRodar.UseVisualStyleBackColor = true;
            this.btnRodar.Click += new System.EventHandler(this.btnRodar_Click);
            // 
            // chkRecursivo
            // 
            this.chkRecursivo.AutoSize = true;
            this.chkRecursivo.Checked = true;
            this.chkRecursivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecursivo.Location = new System.Drawing.Point(22, 390);
            this.chkRecursivo.Name = "chkRecursivo";
            this.chkRecursivo.Size = new System.Drawing.Size(74, 17);
            this.chkRecursivo.TabIndex = 14;
            this.chkRecursivo.Text = "Recursivo";
            this.chkRecursivo.UseVisualStyleBackColor = true;
            // 
            // chkDinamico
            // 
            this.chkDinamico.AutoSize = true;
            this.chkDinamico.Checked = true;
            this.chkDinamico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDinamico.Location = new System.Drawing.Point(22, 414);
            this.chkDinamico.Name = "chkDinamico";
            this.chkDinamico.Size = new System.Drawing.Size(70, 17);
            this.chkDinamico.TabIndex = 15;
            this.chkDinamico.Text = "Dinamico";
            this.chkDinamico.UseVisualStyleBackColor = true;
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.chkDinamico);
            this.Controls.Add(this.chkRecursivo);
            this.Controls.Add(this.btnRodar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.txtInputFibonacci);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInputFibonacci;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zerarListaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrantesToolStripMenuItem;
        private System.Windows.Forms.Button btnRodar;
        private System.Windows.Forms.CheckBox chkRecursivo;
        private System.Windows.Forms.CheckBox chkDinamico;
    }
}

