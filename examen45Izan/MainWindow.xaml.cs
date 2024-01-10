using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace examen45Izan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainWindowVM();
            this.DataContext = vm;
        }

        private void Button_Elimina(object sender, RoutedEventArgs e)
        {
            try
            {
                vm.EliminarSeleccionado();
            }
            catch
            { }
        }

        private void LimpiarSeleccion(object sender, RoutedEventArgs e)
        {
            vm.InmuebleSeleccion = null;
        }
    }
}
