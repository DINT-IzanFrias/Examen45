using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen45Izan.Service
{
    internal class InmuebleService
    {
        public static ObservableCollection<Inmueble> GetSamples()
        {
            ObservableCollection<Inmueble> lista = new ObservableCollection<Inmueble>();

            lista.Add(new Inmueble("piso", "Playa de San Juan (PAU 5)", "Piso de 116m2 con terraza en urbanización con piscina, pistas deportivas, garaje y trastero en el PAU 5. Construido en 2017.", @"Imagenes\foto1.jpg", false, 375000, "Disponible"));
            lista.Add(new Inmueble("piso", "Mercado central", "Exclusiva vivienda en una de las mejores avenidas del centro de la ciudad de Alicante, junto al MERCADO CENTRAL y solo a 8 minutos andando de la playa principal de Alicante - POSTIGUET. Especial inversores, dispone de Licencia Turistica.", @"Imagenes\foto2.jpg", false, 144000, "Disponible"));
            lista.Add(new Inmueble("casa", "Carolinas altas", "Consta de 151 m2 de parcela, de los cuales, 132 m2 son construidos. Tiene posibilidad de construir hasta 3 plantas más áticos.Dispone de un patio amplio dividido en una parte abierta y otra cerrada, adaptada para uso de barbacoa.", @"Imagenes\foto3.jpg", true, 104900, "Reservado"));
            lista.Add(new Inmueble("local", "Albufereta", "Local comercial en Avenida Condomina Nº11, cuenta con 90m2 construidos, totalmente diáfano y con un baño, entrada peatonal y para vehículos desde la avenida hacia el interior de la urbanización donde se encuentra.", @"Imagenes\foto4.jpg", false, 85000, "Disponible"));
            lista.Add(new Inmueble("piso", "San Gabriel", "Piso que se distribuye en salón-comedor, cocina, 3 dormitorios, 1 cuarto de baño y galería. Ubicado próximo a superfícies comerciales, entidades bancarias y cerca de la playa local. Muy bien comunicado por carretera.", @"Imagenes\foto5.jpg", true, 78400, "Vendido"));

            return lista;

        }
    }
}
