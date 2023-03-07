using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrimerParcialProgra1.Entidades;

namespace PrimerParcialProgra1.Negocio
{
    public class ClsVenta
    {
        public string Cobro(Venta ventas){
            ventas.Precio = ventas.Precio * ventas.Cantidad;

            if (ventas.Precio >= 50){
                ventas.Descuento = ventas.Precio - 10;
                return ($"Precio:                  {ventas.Precio} \nPrecio con Descuento:    {ventas.Descuento}\nTOTAL A PAGAR:           {ventas.Descuento}");
            }
            else{
                return ($"Precio                   {ventas.Precio} \nPrecio con Descuento:    {ventas.Descuento}\nTOTAL A PAGAR:           {ventas.Precio}");
            }
        }
    }
}