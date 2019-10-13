using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAtendimento.Model;

namespace ProjetoAtendimento.Controller {
    class Senhas {


        //Atributos
        private int proximoAtendimento;
        private Queue<Model.Senha> filaSenhas;

        //Construtor

        public Senhas() {
            this.proximoAtendimento = 1;
            filaSenhas = new Queue<Model.Senha>();
        }

        //Metodos
        public void gerar() {
            filaSenhas.Enqueue(new Model.Senha(this.proximoAtendimento));
            this.proximoAtendimento++;
        }

        //Getters e Setters
        public int ProximoAtendimento { get => proximoAtendimento; set => proximoAtendimento = value; }
        internal Queue<Senha> FilaSenhas { get => filaSenhas; set => filaSenhas = value; }
    }
}
