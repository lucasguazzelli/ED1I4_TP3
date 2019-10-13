using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAtendimento.Model;

namespace ProjetoAtendimento.Controller {
    class Guiches {

        //Atributos
        private List<Model.Guiche> listaGuiches;

        //Construtor
        public Guiches() {
            this.listaGuiches = new List<Model.Guiche>();
        }

        public void adicionar() {
            this.listaGuiches.Add( new Model.Guiche() );
        }

        //Getters e Setters

        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }
    }
}
