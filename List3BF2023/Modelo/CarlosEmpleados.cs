using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List3BF2023.Modelo
{
    class CarlosEmpleados
    {
        private List<Empleado> ListaEmpleados;

        /* Patrón diseño singleton */
        private static CarlosEmpleados instancia;
        private CarlosEmpleados()
        {
            //ListaEmpleados = new();
            ListaEmpleados = new List<Empleado>();
        }
        public static CarlosEmpleados GetInstancia()
        {
            if(instancia == null)
                instancia = new();

            return instancia;
        }
        /* Patrón diseño singleton - FIN */

        public void Alta(Empleado emp)
        {
            this.ListaEmpleados.Add(emp);
        }

        public System.Data.DataTable ListarDGV()
        {
            System.Data.DataTable dt = new();

            dt.Columns.Add("NSS", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Fecha Nacimiento", typeof(DateTime));
            dt.Columns.Add("Sexo", typeof(char));
            dt.Columns.Add("Salario", typeof(double));

            foreach (Empleado item in ListaEmpleados)
            {
                object[] fila =
                {
                    item.NSS,
                    item.Nombrep,
                    item.FechaN,
                    item.Sexo,
                    item.Salario
                };
                dt.Rows.Add(fila);
            }

            return dt;
        }
    }
}
