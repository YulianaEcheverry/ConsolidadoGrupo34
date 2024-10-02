using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodias_Perfectas
{
    internal class GestionEstudiantes
    {

        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Instrumento { get; set; }
        public long CostoClase { get; set; }
        public long NumeroClase { get; set; }
        public string Genero { get; set; }
        public DateTime FechaIngreso { get; set; }


        public long CalcularCostoTotal()
        {
            return NumeroClase * CostoClase;

        }
    }
}
