namespace PetLove
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lvPets = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Especie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Raça = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Idade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Wheat;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 157);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(446, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 44);
            this.panel2.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Gold;
            this.label12.Location = new System.Drawing.Point(524, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 31);
            this.label12.TabIndex = 17;
            this.label12.Text = "Idade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(353, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 31);
            this.label11.TabIndex = 17;
            this.label11.Text = "Raça";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(182, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 31);
            this.label10.TabIndex = 16;
            this.label10.Text = "Espécie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(26, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "O tratamento real que o seu melhor amigo merece";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(167, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet Love";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(28, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 460);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "(11) 96171-300X";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Gold;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.ImageIndex = 2;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 0);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(216, 58);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.Gold;
            this.btnAtualizar.Location = new System.Drawing.Point(0, 55);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(216, 58);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F);
            this.btnRemover.ForeColor = System.Drawing.Color.Gold;
            this.btnRemover.Location = new System.Drawing.Point(0, 110);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(216, 58);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.Gold;
            this.btnLimpar.Location = new System.Drawing.Point(0, 165);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(216, 58);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lvPets
            // 
            this.lvPets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lvPets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Especie,
            this.Raça,
            this.Idade});
            this.lvPets.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvPets.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPets.ForeColor = System.Drawing.Color.Gold;
            this.lvPets.FullRowSelect = true;
            this.lvPets.GridLines = true;
            this.lvPets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvPets.HideSelection = false;
            this.lvPets.Location = new System.Drawing.Point(446, 157);
            this.lvPets.Name = "lvPets";
            this.lvPets.Size = new System.Drawing.Size(618, 460);
            this.lvPets.TabIndex = 2;
            this.lvPets.UseCompatibleStateImageBehavior = false;
            this.lvPets.View = System.Windows.Forms.View.Details;
            this.lvPets.SelectedIndexChanged += new System.EventHandler(this.lvPets_SelectedIndexChanged);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome Do Pet";
            this.Nome.Width = 175;
            // 
            // Especie
            // 
            this.Especie.Text = "Espécie";
            this.Especie.Width = 104;
            // 
            // Raça
            // 
            this.Raça.Text = "Raça";
            this.Raça.Width = 230;
            // 
            // Idade
            // 
            this.Idade.Text = "Idade Do Pet";
            this.Idade.Width = 123;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNome.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtNome.ForeColor = System.Drawing.Color.Gold;
            this.txtNome.Location = new System.Drawing.Point(222, 210);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(206, 23);
            this.txtNome.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(222, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome do Pet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(222, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Espécie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(224, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Raça:";
            // 
            // txtRaca
            // 
            this.txtRaca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRaca.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRaca.ForeColor = System.Drawing.Color.Gold;
            this.txtRaca.Location = new System.Drawing.Point(222, 325);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(206, 23);
            this.txtRaca.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 17.2F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(222, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdade.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtIdade.ForeColor = System.Drawing.Color.Gold;
            this.txtIdade.Location = new System.Drawing.Point(222, 382);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(79, 23);
            this.txtIdade.TabIndex = 9;
            // 
            // cbEspecie
            // 
            this.cbEspecie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbEspecie.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.cbEspecie.ForeColor = System.Drawing.Color.Wheat;
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Items.AddRange(new object[] {
            "Cachorro",
            "Gato"});
            this.cbEspecie.Location = new System.Drawing.Point(222, 267);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(206, 23);
            this.cbEspecie.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(35, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 23);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1064, 617);
            this.Controls.Add(this.cbEspecie);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lvPets);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1080, 768);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pet Love - Registros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvPets;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Especie;
        private System.Windows.Forms.ColumnHeader Raça;
        private System.Windows.Forms.ColumnHeader Idade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
    }
}

