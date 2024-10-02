using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielVinascoIsaza_Fase2
{
    internal class GestionEstudiantes
    {
        public string Identicacion { get; set; }
        public string Nombre  { get; set; }
        public string Genero { get; set; }
        public string Instrumento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal NumeroDeClases { get; set; }
        public decimal CostoClase { get; set; }
        public decimal CostoTotal { get; set; }

        // hacemos un metodo pata cálcular el costo total 

        public decimal CalcularaCostoTotal()
         {
            return CostoClase * NumeroDeClases;
        
        }
    }
}
