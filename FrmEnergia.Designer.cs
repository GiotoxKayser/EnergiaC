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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnergia));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbMassaCorpos = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalculo2 = new System.Windows.Forms.Button();
            this.txtMassa2 = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtForcaG = new System.Windows.Forms.TextBox();
            this.txtMassa1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabEnergia = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.gbVelocidade = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbEnergia = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbMassa = new System.Windows.Forms.GroupBox();
            this.lblMassa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHelpEnergia = new System.Windows.Forms.Button();
            this.btnHelpVelocidade = new System.Windows.Forms.Button();
            this.btnHelpMassa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMassa = new System.Windows.Forms.TextBox();
            this.txtVelocidade = new System.Windows.Forms.TextBox();
            this.txtEnergiaC = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbMassaCorpos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabEnergia.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbVelocidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbEnergia.SuspendLayout();
            this.gbMassa.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.gbMassaCorpos);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnCalculo2);
            this.tabPage2.Controls.Add(this.txtMassa2);
            this.tabPage2.Controls.Add(this.txtDistancia);
            this.tabPage2.Controls.Add(this.txtForcaG);
            this.tabPage2.Controls.Add(this.txtMassa1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.ImageIndex = 2;
            this.tabPage2.Location = new System.Drawing.Point(4, 71);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Força Gravitacional";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // gbMassaCorpos
            // 
            this.gbMassaCorpos.Controls.Add(this.label12);
            this.gbMassaCorpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMassaCorpos.Location = new System.Drawing.Point(388, 11);
            this.gbMassaCorpos.Name = "gbMassaCorpos";
            this.gbMassaCorpos.Size = new System.Drawing.Size(372, 145);
            this.gbMassaCorpos.TabIndex = 12;
            this.gbMassaCorpos.TabStop = false;
            this.gbMassaCorpos.Text = "Massa dos Corpos ";
            this.gbMassaCorpos.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(296, 100);
            this.label12.TabIndex = 0;
            this.label12.Text = "- Velocidade é a media do deslocamento\r\n em kilometros por hora\r\n- V = (Xf - Xi )" +
    "/ t\r\n        Por exemplo:\r\n        Velocidade de um carro = 70 k/h";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 163);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Força Gravitacional ";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(34, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Força gravitacional :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Distancia entre os corpos :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Massa do primeiro corpo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Massa do segundo corpo:";
            // 
            // btnCalculo2
            // 
            this.btnCalculo2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCalculo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCalculo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCalculo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCalculo2.Location = new System.Drawing.Point(255, 161);
            this.btnCalculo2.Name = "btnCalculo2";
            this.btnCalculo2.Size = new System.Drawing.Size(100, 27);
            this.btnCalculo2.TabIndex = 0;
            this.btnCalculo2.Text = "Calcular";
            this.btnCalculo2.UseVisualStyleBackColor = true;
            this.btnCalculo2.Click += new System.EventHandler(this.btnNumero3_Click);
            // 
            // txtMassa2
            // 
            this.txtMassa2.Location = new System.Drawing.Point(257, 63);
            this.txtMassa2.Name = "txtMassa2";
            this.txtMassa2.Size = new System.Drawing.Size(100, 20);
            this.txtMassa2.TabIndex = 1;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(255, 101);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 1;
            // 
            // txtForcaG
            // 
            this.txtForcaG.Location = new System.Drawing.Point(255, 135);
            this.txtForcaG.Name = "txtForcaG";
            this.txtForcaG.Size = new System.Drawing.Size(100, 20);
            this.txtForcaG.TabIndex = 1;
            // 
            // txtMassa1
            // 
            this.txtMassa1.Location = new System.Drawing.Point(257, 26);
            this.txtMassa1.Name = "txtMassa1";
            this.txtMassa1.Size = new System.Drawing.Size(100, 20);
            this.txtMassa1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(636, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 134);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // tabEnergia
            // 
            this.tabEnergia.Controls.Add(this.tabPage1);
            this.tabEnergia.Controls.Add(this.tabPage2);
            this.tabEnergia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabEnergia.ImageList = this.imageList1;
            this.tabEnergia.Location = new System.Drawing.Point(-4, 48);
            this.tabEnergia.Name = "tabEnergia";
            this.tabEnergia.SelectedIndex = 0;
            this.tabEnergia.Size = new System.Drawing.Size(832, 484);
            this.tabEnergia.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabEnergia.TabIndex = 4;
            this.tabEnergia.SelectedIndexChanged += new System.EventHandler(this.tabEnergia_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.lblCalculo);
            this.tabPage1.Controls.Add(this.gbVelocidade);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.gbEnergia);
            this.tabPage1.Controls.Add(this.gbMassa);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtMassa);
            this.tabPage1.Controls.Add(this.txtVelocidade);
            this.tabPage1.Controls.Add(this.txtEnergiaC);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 71);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Energia Cinética";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculo.Location = new System.Drawing.Point(21, 197);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(0, 16);
            this.lblCalculo.TabIndex = 9;
            // 
            // gbVelocidade
            // 
            this.gbVelocidade.Controls.Add(this.label5);
            this.gbVelocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVelocidade.Location = new System.Drawing.Point(407, 35);
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
            this.label5.Location = new System.Drawing.Point(26, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 100);
            this.label5.TabIndex = 0;
            this.label5.Text = "- Velocidade é a media do deslocamento\r\n em kilometros por hora\r\n- V = (Xf - Xi )" +
    "/ t\r\n        Por exemplo:\r\n        Velocidade de um carro = 70 k/h";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(636, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 134);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // gbEnergia
            // 
            this.gbEnergia.Controls.Add(this.label6);
            this.gbEnergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnergia.Location = new System.Drawing.Point(407, 35);
            this.gbEnergia.Name = "gbEnergia";
            this.gbEnergia.Size = new System.Drawing.Size(395, 145);
            this.gbEnergia.TabIndex = 5;
            this.gbEnergia.TabStop = false;
            this.gbEnergia.Text = "Energia Cinética";
            this.gbEnergia.Visible = false;
            this.gbEnergia.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 120);
            this.label6.TabIndex = 0;
            this.label6.Text = "- Energia Cinética é a energia\r\n do movimento em Joules\r\n- Energia cinética = 1/2" +
    " * ((Velocidade ^2)  * Massa) \r\n      Por Exemplo:\r\n      Uma bola caindo = 15 J" +
    "\r\n ";
            // 
            // gbMassa
            // 
            this.gbMassa.Controls.Add(this.lblMassa);
            this.gbMassa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMassa.Location = new System.Drawing.Point(407, 34);
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
            this.groupBox1.Size = new System.Drawing.Size(211, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.btnHelpEnergia.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHelpEnergia.Location = new System.Drawing.Point(10, 100);
            this.btnHelpEnergia.Name = "btnHelpEnergia";
            this.btnHelpEnergia.Size = new System.Drawing.Size(34, 23);
            this.btnHelpEnergia.TabIndex = 3;
            this.btnHelpEnergia.Text = "?";
            this.btnHelpEnergia.UseVisualStyleBackColor = false;
            this.btnHelpEnergia.Click += new System.EventHandler(this.btnHelpEnergia_Click);
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
            this.btnHelpVelocidade.ForeColor = System.Drawing.Color.DarkRed;
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
            this.btnHelpMassa.ForeColor = System.Drawing.Color.DarkRed;
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
            // txtMassa
            // 
            this.txtMassa.Location = new System.Drawing.Point(223, 39);
            this.txtMassa.Name = "txtMassa";
            this.txtMassa.Size = new System.Drawing.Size(178, 20);
            this.txtMassa.TabIndex = 1;
            // 
            // txtVelocidade
            // 
            this.txtVelocidade.Location = new System.Drawing.Point(223, 76);
            this.txtVelocidade.Name = "txtVelocidade";
            this.txtVelocidade.Size = new System.Drawing.Size(178, 20);
            this.txtVelocidade.TabIndex = 1;
            // 
            // txtEnergiaC
            // 
            this.txtEnergiaC.Location = new System.Drawing.Point(223, 111);
            this.txtEnergiaC.Name = "txtEnergiaC";
            this.txtEnergiaC.Size = new System.Drawing.Size(178, 20);
            this.txtEnergiaC.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(223, 157);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(178, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close_icon-icons.com_50420.png");
            this.imageList1.Images.SetKeyName(1, "exercise-icon-256.png");
            this.imageList1.Images.SetKeyName(2, "impact-point_39078.png");
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
            this.button1.Location = new System.Drawing.Point(659, 1);
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
            this.Fechar.Location = new System.Drawing.Point(741, 1);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Energia Cinética 1.05.3.1v";
            // 
            // btnCredits
            // 
            this.btnCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCredits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCredits.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCredits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCredits.Location = new System.Drawing.Point(577, 1);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(76, 34);
            this.btnCredits.TabIndex = 7;
            this.btnCredits.Text = "Credits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-4, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 1);
            this.panel1.TabIndex = 7;
            // 
            // FrmEnergia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(822, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabEnergia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEnergia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Energia Cinética";
            this.Load += new System.EventHandler(this.FrmEnergia_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmEnergia_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmEnergia_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmEnergia_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbMassaCorpos.ResumeLayout(false);
            this.gbMassaCorpos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabEnergia.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbVelocidade.ResumeLayout(false);
            this.gbVelocidade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbEnergia.ResumeLayout(false);
            this.gbEnergia.PerformLayout();
            this.gbMassa.ResumeLayout(false);
            this.gbMassa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabEnergia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.GroupBox gbVelocidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbEnergia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbMassa;
        private System.Windows.Forms.Label lblMassa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHelpEnergia;
        private System.Windows.Forms.Button btnHelpVelocidade;
        private System.Windows.Forms.Button btnHelpMassa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMassa;
        private System.Windows.Forms.TextBox txtVelocidade;
        private System.Windows.Forms.TextBox txtEnergiaC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtMassa1;
        private System.Windows.Forms.TextBox txtMassa2;
        private System.Windows.Forms.Button btnCalculo2;
        private System.Windows.Forms.TextBox txtForcaG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbMassaCorpos;
        private System.Windows.Forms.Label label12;
    }
}

