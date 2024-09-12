using System;
using System.Windows.Forms;

namespace RadioECheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int creditos = 0;
            if (chckBxDesDesk.Checked)
            {
                creditos++;
            }
            if (chckBxProbEst.Checked)
            {
                creditos++;
            }
            int pontos = 0;
            if (rdBtnMundial.Checked)
            {
                pontos++;
            }
            if (rdBtnMondial.Checked)
            {
                pontos++;
            }
            //verifica se foi escolhida alguma disciplina
            if (creditos > 0)
            {
                if (pontos < creditos)
                {
                    DialogResult resultado = MessageBox.Show("Você não possui pontos suficientes. " +
                        "Deseja continuar?",
                        "Teste de Conhecimento", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (resultado == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    else if (resultado == DialogResult.Yes)
                    {
                        limparFornulario();
                    }
                    else
                    {
                        //clicou no x
                        MessageBox.Show("voce fechou com o 'X'.");
                    }
                }
                else
                {
                    MessageBox.Show("Parabéns, você conseguiu pontos suficientes");
                }
            }
            else
            {
                MessageBox.Show("Você deve escolher 1 ou 2 disciplinas!",
                    "Teste de Conhecimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limparFornulario()
        {
            //linpar o form
            chckBxDesDesk.Checked = false;
            chckBxProbEst.Checked = false;
            rdBtnMundial.Checked = false;
            rdBtnMundiel.Checked = false;
            rdBtnMundiil.Checked = false;
            rdBtnMundiol.Checked = false;
            rdBtnMundiul.Checked = false;

            rdBtnMondial.Checked = false;
            rdBtnSamsung.Checked = false;
            rdBtnBrastemp.Checked = false;
            rdBtnEletrolux.Checked = false;
            rdBtnLG.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Voce realmente deseja sair? ",
                "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (resultado == DialogResult.No)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.Yes)
            {
                limparFornulario();
            }
            else
            {
                //clicou no x
                MessageBox.Show("voce fechou com o 'X'.");
            }
        }
    }
}
