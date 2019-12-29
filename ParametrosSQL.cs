using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaykonSoft
{
    public class ParametrosSQL


    {

       // Atributos da classe Parametros
        public string Servidor { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }


       public ParametrosSQL()
        {

        }

       public ParametrosSQL(string s, string u, string senha)
        {
            this.Servidor = ".\\sqlng";
            this.User = "sa";
            this.Senha = "teste";
        }










    }
}
