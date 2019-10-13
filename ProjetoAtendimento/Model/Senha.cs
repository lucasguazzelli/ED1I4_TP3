using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento.Model {
    class Senha {

        //Atributos

        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        //Construtor

        public Senha(int id) {
            this.id = id;
            this.dataGerac = DateTime.Now.Date;
            this.horaGerac = DateTime.Now;
        }

        //Metodos

        public string dadosParciais() {
            return id + " - " + dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm:ss");
        }

        public string dadosCompletos() {
            return id + " - " + dataGerac.ToString("dd/MM/yyyy") + " - " + horaGerac.ToString("HH:mm:ss") + " - " + dataAtend.ToString("dd/MM/yyyy") + " - " + horaAtend.ToString("HH:mm:ss");
        }

        //Getters e Setters
        public int Id { get => id; set => id = value; }
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public DateTime HoraGerac { get => horaGerac; set => horaGerac = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }
        public DateTime HoraAtend { get => horaAtend; set => horaAtend = value; }


    }
}
