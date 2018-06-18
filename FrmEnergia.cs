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
            Decimal Massa, Velocidade, Energia;     //Define as seguintes variaveis em decimal

            String Calculo;
            Decimal i;
            if (txtMassa.Text == String.Empty)
            {
                MessageBox.Show("Insira os valores da Massa\n", "Erro");
            }
            else {
                if (Decimal.TryParse(txtMassa.Text, out i))     //verificar se o txtMassa é um número decimal
                {

                    if (Decimal.TryParse(txtVelocidade.Text, out i))   //verificar se o txtVelocidade é um número
                    {

                        Velocidade = Convert.ToDecimal(txtVelocidade.Text);

                        Massa = Convert.ToDecimal(txtMassa.Text);

                        Decimal Resultado = ((Massa * (Velocidade * Velocidade)) * 1 / 2);      //Realização a equação
                        txtEnergiaC.Text = Resultado.ToString();                                //Recebe a string Resultado na txtEnergiaC

                        Calculo = Convert.ToString(lblCalculo.Text);
                        lblCalculo.Text = ("Massa = " + Massa + "\nVelocidade = " + Velocidade + "\n   A formula de energia cinética é (Velocidade² * Massa) * 1/2 \n   Então para descobrir a energia cinética, colocamos os dados na formula" + "\n(" + Velocidade + "² *" + Massa + ") * 1/2" + "\n   Resolveremos primeiro o que esta em parentes\n(" + Velocidade * Velocidade + "+" + Massa + ") * 1/2" + "\n" + Velocidade * Velocidade * Massa + " * 1/2" + "\n   Agora multiplicamos por 1/2" + "\n" + "   A energia cinética deu " + Resultado + " J");  // Criar uma Label capaz de mostra ao usuário como é feito a equãção
                    }
                    else
                    {

                        MessageBox.Show("Insira os valores da Velocidade\nApenas números", "Erro");  //Msgbox caso a txtVelocidade não seja um numero

                    }
                }
                else {
                    MessageBox.Show("Apenas números", "Erro");
                }

            }

            
            

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();  //botão de fechar
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            Desenho desenho = new Desenho();  //ainda sem função
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
            this.WindowState = FormWindowState.Minimized;  //minimiza a tela
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

        private void FrmEnergia_MouseUp(object sender, MouseEventArgs e)    //Função de arrastar a tela usando a Form
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

        private void btnHelpMassa_Click(object sender, EventArgs e)  //Deixa visivel a label selecionada e deixa invisivel as nao selecionadas
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
            MessageBox.Show("Giovane Matheus Kayser Fernandes", "Credits");  //EU
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            
        }

        private void tabEnergia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
