using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialProgra1.Entidades
{
    public class Venta
    {
        public int Identificador {get; set;}
        public String Nombre {get;set;}
        public String Descripcion {get; set;}
        public decimal Precio {get; set;}
        public int Cantidad {get; set;}
        public decimal Descuento {get; set;}

    }
}