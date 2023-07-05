using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List3BF2023.Modelo
{
    class Empleado
    {
        //NSSSUPER	ND
        private string nss;
        private string nombrep;
        //private string apellido;
        private DateTime fechan;
        //private string dir;
        private char sexo;
        private double salario;

        public Empleado(string nss, string nombrep, DateTime fechan, char sexo, double salario)
        {
            this.nss = nss;
            this.nombrep = nombrep;
            this.fechan = fechan;
            this.sexo = sexo;
            this.salario = salario;
        }

        public string NSS { get { return this.nss; } }

        public string Nombrep { get { return this.nombrep; } set { this.nombrep = value; } }

        public DateTime FechaN { get { return this.fechan; } set { this.fechan = value; } }

        public char Sexo { get { return this.sexo; } set { this.sexo = value; } }

        public double Salario { get { return this.salario; } set { this.salario = value; } }
    }
}
