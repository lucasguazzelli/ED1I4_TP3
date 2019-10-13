using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    public partial class Form1 : Form
    {
        //Atributos
        Controller.Senhas senhas;
        Controller.Guiches guiches;

        //ViewDidLoad
        public Form1() {
            InitializeComponent();
            senhas = new Controller.Senhas();
            guiches = new Controller.Guiches();
        }

        private void ButtonGerar_Click(object sender, EventArgs e) {
            senhas.gerar();
            atualizarListBoxSenha();
        }

        private void ButtonAddGuiche_Click(object sender, EventArgs e) {
            guiches.adicionar();
            labelQtGuiche.Text = Convert.ToString(guiches.ListaGuiches.Count);
        }

        private void ButtonCallGuiche_Click(object sender, EventArgs e) {
            Int16 guicheSelect = Convert.ToInt16(textBoxGuiche.Text);
            guiches.ListaGuiches[guicheSelect-1].chamar( senhas.FilaSenhas );
            listBoxGuiche.Items.Clear();
            foreach (Model.Senha atendimento in this.guiches.ListaGuiches[guicheSelect-1].Atendimentos) {
                listBoxGuiche.Items.Add(atendimento.dadosCompletos());
            }
            atualizarListBoxSenha();
        }

        public void atualizarListBoxSenha() {
            listBoxSenhas.Items.Clear();
            foreach (Model.Senha umaSenha in senhas.FilaSenhas) {
                listBoxSenhas.Items.Add(umaSenha.dadosParciais());
            }
        }

        private void TextBoxGuiche_TextChanged(object sender, EventArgs e) {

        }

        private void ButtonListar_Click(object sender, EventArgs e) {

        }

        /* DESATIVADO
        private void ButtonListarSenhas_Click(object sender, EventArgs e) {
            listBoxSenhas.Items.Clear();
            foreach (Model.Senha umaSenha in senhas.FilaSenhas) {
                listBoxSenhas.Items.Add(umaSenha.dadosParciais());
            }
        }
        */
    }
}
