using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2JessicaCatherineLozano
{
    internal class GestionEstudiantes
    {
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }
        public string Genero { get; set; }
        public string Instrumento { get; set; }
        public int NumeroClases { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal CostoPorClase { get; set; }
        public decimal CostoTotal { get; set; }


        public decimal CalcularCostoTotal()
        {
            return NumeroClases * CostoPorClase;
        }


    }
}
