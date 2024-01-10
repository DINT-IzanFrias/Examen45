using CommunityToolkit.Mvvm.ComponentModel;
using examen45Izan.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen45Izan
{
    internal class MainWindowVM : ObservableObject
    {
        private ObservableCollection<String> estados; 
        public ObservableCollection<String> Estados
        { 
            get { return estados; } 
            set { SetProperty(ref estados, value); }
        }
        private Inmueble inmuebleSeleccion;
        public Inmueble InmuebleSeleccion
        {
            get {  return inmuebleSeleccion;}
            set { SetProperty(ref inmuebleSeleccion,value);}
        }
        public ObservableCollection<Inmueble> inmuebles;
        public ObservableCollection<Inmueble> Inmuebles
        {
            get { return inmuebles; }
            set
            {
                SetProperty(ref inmuebles, value);
            }
        }

        public InmuebleService inmuebleService = new InmuebleService();

        public MainWindowVM()
        {
            inmuebles = new ObservableCollection<Inmueble>();
            inmuebles = InmuebleService.GetSamples();

            estados= new ObservableCollection<String>();
            estados.Add("Disponible");
            estados.Add("Reservado");
            estados.Add("Vendido");
        }
        
        public void EliminarSeleccionado()
        {
            inmuebles.Remove(InmuebleSeleccion);
        }
    }
}
