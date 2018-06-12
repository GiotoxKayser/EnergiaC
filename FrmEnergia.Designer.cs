namespace Energia_Cinética
{
    partial class FrmEnergia
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbMassa = new System.Windows.Forms.GroupBox();
            this.lblMassa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHelpEnergia = new System.Windows.Forms.Button();
            this.btnHelpVelocidade = new System.Windows.Forms.Button();
            this.btnHelpMassa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDesenhar = new System.Windows.Forms.Button();
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.txtEnergiaC = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tabEnergia = new System.Windows.Forms.TabControl();
            this.button1 = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbVelocidade = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.gbMassa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabEnergia.SuspendLayout();
            this.gbVelocidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exemplo";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.gbVelocidade);
            this.tabPage1.Controls.Add(this.gbMassa);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnDesenhar);
            this.tabPage1.Controls.Add(this.txtMassa);
            this.tabPage1.Controls.Add(this.txtVelocidade);
            this.tabPage1.Controls.Add(this.txtEnergiaC);
            this.tabPage1.Controls.Add(this.btnFechar);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Energia Cinética";
            // 
            // gbMassa
            // 
            this.gbMassa.Controls.Add(this.lblMassa);
            this.gbMassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMassa.Location = new System.Drawing.Point(374, 35);
            this.gbMassa.Name = "gbMassa";
            this.gbMassa.Size = new System.Drawing.Size(372, 130);
            this.gbMassa.TabIndex = 4;
            this.gbMassa.TabStop = false;
            this.gbMassa.Text = "Massa";
            this.gbMassa.Visible = false;
            this.gbMassa.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblMassa
            // 
            this.lblMassa.AutoSize = true;
            this.lblMassa.Location = new System.Drawing.Point(19, 34);
            this.lblMassa.Name = "lblMassa";
            this.lblMassa.Size = new System.Drawing.Size(339, 80);
            this.lblMassa.TabIndex = 0;
            this.lblMassa.Text = "- Massa do corpo ou do objeto em (kilogramas)\r\n- Exemplo:\r\n        1. Massa de um" +
    "a bola de boliche = 7 kg\r\n        2. Massa de um prato = 0,1 kg";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnHelpEnergia);
            this.groupBox1.Controls.Add(this.btnHelpVelocidade);
            this.groupBox1.Controls.Add(this.btnHelpMassa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Energia Cinética:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidade:";
            // 
            // btnHelpEnergia
            // 
            this.btnHelpEnergia.BackColor = System.Drawing.Color.White;
            this.btnHelpEnergia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHelpEnergia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpEnergia.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHelpEnergia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnHelpEnergia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnHelpEnergia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpEnergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpEnergia.Location = new System.Drawing.Point(10, 100);
            this.btnHelpEnergia.Name = "btnHelpEnergia";
            this.btnHelpEnergia.Size = new System.Drawing.Size(34, 23);
            this.btnHelpEnergia.TabIndex = 3;
            this.btnHelpEnergia.Text = "?";
            this.btnHelpEnergia.UseVisualStyleBackColor = false;
            this.btnHelpEnergia.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // btnHelpVelocidade
            // 
            this.btnHelpVelocidade.BackColor = System.Drawing.Color.White;
            this.btnHelpVelocidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHelpVelocidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpVelocidade.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHelpVelocidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnHelpVelocidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnHelpVelocidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpVelocidade.Location = new System.Drawing.Point(10, 65);
            this.btnHelpVelocidade.Name = "btnHelpVelocidade";
            this.btnHelpVelocidade.Size = new System.Drawing.Size(34, 23);
            this.btnHelpVelocidade.TabIndex = 3;
            this.btnHelpVelocidade.Text = "?";
            this.btnHelpVelocidade.UseVisualStyleBackColor = false;
            this.btnHelpVelocidade.Click += new System.EventHandler(this.btnHelpVelocidade_Click);
            // 
            // btnHelpMassa
            // 
            this.btnHelpMassa.BackColor = System.Drawing.Color.White;
            this.btnHelpMassa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHelpMassa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpMassa.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHelpMassa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnHelpMassa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnHelpMassa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpMassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpMassa.Location = new System.Drawing.Point(10, 33);
            this.btnHelpMassa.Name = "btnHelpMassa";
            this.btnHelpMassa.Size = new System.Drawing.Size(34, 23);
            this.btnHelpMassa.TabIndex = 3;
            this.btnHelpMassa.Text = "?";
            this.btnHelpMassa.UseVisualStyleBackColor = false;
            this.btnHelpMassa.Click += new System.EventHandler(this.btnHelpMassa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Massa:";
            // 
            // btnDesenhar
            // 
            this.btnDesenhar.BackColor = System.Drawing.Color.White;
            this.btnDesenhar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDesenhar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesenhar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDesenhar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnDesenhar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnDesenhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesenhar.Location = new System.Drawing.Point(16, 142);
            this.btnDesenhar.Name = "btnDesenhar";
            this.btnDesenhar.Size = new System.Drawing.Size(125, 23);
            this.btnDesenhar.TabIndex = 3;
            this.btnDesenhar.Text = "Desenho";
            this.btnDesenhar.UseVisualStyleBackColor = false;
            this.btnDesenhar.Click += new System.EventHandler(this.btnDesenhar_Click);
            // 
            // txtMassa
            // 
            this.txtMassa.Location = new System.Drawing.Point(190, 39);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(178, 20);
            this.txtMassa.TabIndex = 1;
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(190, 74);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(178, 20);
            this.txtVelocidade.TabIndex = 1;
            // 
            // txtEnergiaC
            // 
            this.txtEnergiaC.Location = new System.Drawing.Point(190, 111);
            this.txtEnergiaC.Name = "txtEnergiaC";
            this.txtEnergiaC.Size = new System.Drawing.Size(178, 20);
            this.txtEnergiaC.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.White;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(251, 142);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(148, 142);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // tabEnergia
            // 
            this.tabEnergia.Controls.Add(this.tabPage1);
            this.tabEnergia.Controls.Add(this.tabPage2);
            this.tabEnergia.Location = new System.Drawing.Point(12, 48);
            this.tabEnergia.Name = "tabEnergia";
            this.tabEnergia.SelectedIndex = 0;
            this.tabEnergia.Size = new System.Drawing.Size(783, 437);
            this.tabEnergia.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(636, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Minimizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Fechar
            // 
            this.Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fechar.Location = new System.Drawing.Point(718, 3);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(61, 34);
            this.Fechar.TabIndex = 6;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Energia Cinética 1.01v";
            // 
            // gbVelocidade
            // 
            this.gbVelocidade.Controls.Add(this.label5);
            this.gbVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVelocidade.Location = new System.Drawing.Point(374, 35);
            this.gbVelocidade.Name = "gbVelocidade";
            this.gbVelocidade.Size = new System.Drawing.Size(372, 145);
            this.gbVelocidade.TabIndex = 4;
            this.gbVelocidade.TabStop = false;
            this.gbVelocidade.Text = "Velocidade";
            this.gbVelocidade.Visible = false;
            this.gbVelocidade.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 100);
            this.label5.TabIndex = 0;
            this.label5.Text = "- Velocidade é a media do deslocamento\r\n em kilometros por hora\r\n- V = (Xf - Xi )" +
    "/ t\r\n        Por exemplo:\r\n        Velocidade de um carro = 70 k/h";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FrmEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(805, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabEnergia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEnergia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Energia Cinética";
            this.Load += new System.EventHandler(this.FrmEnergia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmEnergia_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmEnergia_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmEnergia_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbMassa.ResumeLayout(false);
            this.gbMassa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabEnergia.ResumeLayout(false);
            this.gbVelocidade.ResumeLayout(false);
            this.gbVelocidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabEnergia;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesenhar;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.TextBox txtEnergiaC;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbMassa;
        private System.Windows.Forms.Label lblMassa;
        private System.Windows.Forms.Button btnHelpEnergia;
        private System.Windows.Forms.Button btnHelpVelocidade;
        private System.Windows.Forms.Button btnHelpMassa;
        private System.Windows.Forms.GroupBox gbVelocidade;
        private System.Windows.Forms.Label label5;
    }
}

