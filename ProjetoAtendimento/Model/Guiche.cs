using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento.Model {
    class Guiche {

        //Atributos
        private int id;
        private Queue<Senha> atendimentos;

        //Construtor
        public Guiche() {
            this.id = 0;
            this.atendimentos = new Queue<Senha>();
        }
        public Guiche(int id) {
            this.id = id;
            this.atendimentos = new Queue<Senha>();
        }

        //Metodos
        public bool chamar(Queue<Senha> filaSenhas) {
            try {
                Senha senhaAtendida = filaSenhas.Peek();
                senhaAtendida.DataAtend = DateTime.Now.Date;
                senhaAtendida.HoraAtend = DateTime.Now;
                this.atendimentos.Enqueue(senhaAtendida);
                filaSenhas.Dequeue();
                return true;
            } catch (Exception) {
                return false;
            }
        }

        //Getters e Setters
        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }
    }
}
