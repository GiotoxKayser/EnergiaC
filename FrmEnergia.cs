using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Energia_Cinética
{
    public partial class FrmEnergia : Form
    {
        
        public FrmEnergia()
        {
            InitializeComponent();
        }
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;

        private void FrmEnergia_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Decimal Massa, Velocidade, Energia;


            if (txtMassa.Text == string.Empty || txtVelocidade.Text == string.Empty)
            {
                MessageBox.Show("Massa ou Velocidade está Vazio!", "Erro");
            }

            else
            {
                Massa = Convert.ToDecimal(txtMassa.Text);
                Velocidade = Convert.ToDecimal(txtVelocidade.Text);

                Decimal Resultado = ((Massa * (Velocidade * Velocidade)) * 1 / 2);
                txtEnergiaC.Text = Resultado.ToString();
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            Desenho desenho = new Desenho();
            desenho.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmEnergia_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
        }

        private void FrmEnergia_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void FrmEnergia_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnHelpMassa_Click(object sender, EventArgs e)
        {
            gbMassa.Show();
            gbVelocidade.Hide();
            gbEnergia.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHelpVelocidade_Click(object sender, EventArgs e)
        {
            gbMassa.Hide();
            gbVelocidade.Show();
            gbEnergia.Hide();

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnHelpEnergia_Click(object sender, EventArgs e)
        {
            gbEnergia.Show();
            gbMassa.Hide();
            gbVelocidade.Hide();
            
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giovane Matheus Kayser Fernandes lindo gostoso", "Credits");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Segundo esse programa ARROZ È DIVINO");
        }
    }
}
