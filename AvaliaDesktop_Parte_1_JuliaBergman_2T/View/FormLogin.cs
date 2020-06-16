using AvaliaDesktop_Parte_1_JuliaBergman_2T.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliaDesktop_Parte_1_JuliaBergman_2T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // botao entrar, ao clicar, vai direto pra tela principal (entrando como usuário) 
            new FormTelaPrincipal().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // botao de sair, só clicar que sai de tudo e para de rodar o código também
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // botao cadastrar, ao clicar vai direto pra tela de cadastro :)

            new FormCadastro().ShowDialog();

        }

        private void textBox2_TextChanged(object sender, EventArgs e) 
        {
            // aqui tranforma tudo oq for escrito na senha em* (só visualmente, claro)
            textBox2.PasswordChar = '*';
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
