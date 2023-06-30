using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProvaPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_profissao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_nascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tx_sexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_inicioP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                string nome = "Joana";
                string cpf = "4938509348";
                string profissao = "";
                string sexo = "";
                int idade = 11/12/1980;
                int inicioP = 30;
                bool Homem = false;
                bool Professor = false;
                bool AgenteSeguranca = false;


                Verificar v = new Verificar(nome, cpf, profissao, sexo, idade, inicioP, Homem, Professor, AgenteSeguranca);
                v.nome = tx_nome.Text;
                v.cpf = tx_cpf.Text;
                v.profissao = tx_profissao.Text;
                v.sexo = tx_sexo.Text;
                v.idade = Convert.ToInt32(tx_idade.Text);
                v.inicioP = Convert.ToInt32(tx_inicioP.Text);

                double pontosFaltantes = v.CalcularPontosFaltantesAposentadoria();
                lb_confirm.Text = "Pontos faltantes para aposentadoria " + pontosFaltantes.ToString();
       

        }
    }
}
