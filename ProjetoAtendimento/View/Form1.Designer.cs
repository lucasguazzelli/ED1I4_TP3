namespace ProjetoAtendimento
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
            if (disposing && (components != null)) {
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
            this.listBoxGuiche = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.listBoxSenhas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCallGuiche = new System.Windows.Forms.Button();
            this.textBoxGuiche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQtGuiche = new System.Windows.Forms.Label();
            this.buttonAddGuiche = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGuiche
            // 
            this.listBoxGuiche.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGuiche.FormattingEnabled = true;
            this.listBoxGuiche.ItemHeight = 20;
            this.listBoxGuiche.Location = new System.Drawing.Point(6, 49);
            this.listBoxGuiche.Name = "listBoxGuiche";
            this.listBoxGuiche.Size = new System.Drawing.Size(359, 184);
            this.listBoxGuiche.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGerar);
            this.groupBox1.Controls.Add(this.listBoxSenhas);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fila de Espera";
            // 
            // buttonGerar
            // 
            this.buttonGerar.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerar.Location = new System.Drawing.Point(39, 21);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(130, 29);
            this.buttonGerar.TabIndex = 1;
            this.buttonGerar.Text = "Gerar nova Senha";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.ButtonGerar_Click);
            // 
            // listBoxSenhas
            // 
            this.listBoxSenhas.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSenhas.FormattingEnabled = true;
            this.listBoxSenhas.ItemHeight = 20;
            this.listBoxSenhas.Location = new System.Drawing.Point(6, 54);
            this.listBoxSenhas.Name = "listBoxSenhas";
            this.listBoxSenhas.Size = new System.Drawing.Size(201, 184);
            this.listBoxSenhas.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonListar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxGuiche);
            this.groupBox2.Controls.Add(this.buttonCallGuiche);
            this.groupBox2.Controls.Add(this.listBoxGuiche);
            this.groupBox2.Location = new System.Drawing.Point(346, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 239);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fila de Atendimento";
            // 
            // buttonCallGuiche
            // 
            this.buttonCallGuiche.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCallGuiche.Location = new System.Drawing.Point(223, 14);
            this.buttonCallGuiche.Name = "buttonCallGuiche";
            this.buttonCallGuiche.Size = new System.Drawing.Size(75, 29);
            this.buttonCallGuiche.TabIndex = 1;
            this.buttonCallGuiche.Text = "Chamar";
            this.buttonCallGuiche.UseVisualStyleBackColor = true;
            this.buttonCallGuiche.Click += new System.EventHandler(this.ButtonCallGuiche_Click);
            // 
            // textBoxGuiche
            // 
            this.textBoxGuiche.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGuiche.Location = new System.Drawing.Point(61, 17);
            this.textBoxGuiche.Name = "textBoxGuiche";
            this.textBoxGuiche.Size = new System.Drawing.Size(100, 23);
            this.textBoxGuiche.TabIndex = 2;
            this.textBoxGuiche.TextChanged += new System.EventHandler(this.TextBoxGuiche_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guichê";
            // 
            // buttonListar
            // 
            this.buttonListar.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListar.Location = new System.Drawing.Point(304, 14);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(61, 29);
            this.buttonListar.TabIndex = 4;
            this.buttonListar.Text = "Listar";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.ButtonListar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qtde Guichês";
            // 
            // labelQtGuiche
            // 
            this.labelQtGuiche.AutoSize = true;
            this.labelQtGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtGuiche.Location = new System.Drawing.Point(269, 123);
            this.labelQtGuiche.Name = "labelQtGuiche";
            this.labelQtGuiche.Size = new System.Drawing.Size(27, 29);
            this.labelQtGuiche.TabIndex = 4;
            this.labelQtGuiche.Text = "0";
            // 
            // buttonAddGuiche
            // 
            this.buttonAddGuiche.Font = new System.Drawing.Font("Segoe UI", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGuiche.Location = new System.Drawing.Point(245, 160);
            this.buttonAddGuiche.Name = "buttonAddGuiche";
            this.buttonAddGuiche.Size = new System.Drawing.Size(75, 27);
            this.buttonAddGuiche.TabIndex = 5;
            this.buttonAddGuiche.Text = "Adicionar";
            this.buttonAddGuiche.UseVisualStyleBackColor = true;
            this.buttonAddGuiche.Click += new System.EventHandler(this.ButtonAddGuiche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 262);
            this.Controls.Add(this.buttonAddGuiche);
            this.Controls.Add(this.labelQtGuiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGuiche;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.ListBox listBoxSenhas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGuiche;
        private System.Windows.Forms.Button buttonCallGuiche;
        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelQtGuiche;
        private System.Windows.Forms.Button buttonAddGuiche;
    }
}

