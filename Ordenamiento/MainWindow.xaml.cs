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
using System.Collections.ObjectModel;
  
namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<int> miLista = new ObservableCollection<int>();
        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(67);
            miLista.Add(88);
            miLista.Add(98);
            miLista.Add(12);
            miLista.Add(22);
            miLista.Add(32);
            miLista.Add(562);
            miLista.Add(167);
            


            lstnumeros.ItemsSource = miLista;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //variable temporal, estos haran que se intercambien los valores, no se tiene que refrescar porque solo es un cambio de lugar.
            /*var temp = miLista[0]; 
            miLista[0] = miLista[3];
            miLista[3] = temp;*/

            int gab, temp, i, j;
            gab = miLista.Count / 2; //el numero de elementos entre dos
            

            while(gab>0)
            {
                for(i=0; i<miLista.Count; i++)
                {
                    

                        if (gab + i< miLista.Count && miLista[i] > miLista[gab + i])
                        {
                            temp = miLista[i];
                            miLista[i] = miLista[gab + i];
                            miLista[gab + i] = temp;
                        }
                    
                    
                }
                gab--; //restar uno 
            }

        }



        private void BtnBubble_Click(object sender, RoutedEventArgs e)
        {
           
            
            
            bool intercambio = false;
            do
            {


                intercambio = false;
                for(int i=0; i<miLista.Count-1; i++)
                {
                    
                        if(miLista[i]>miLista[i++])
                        {
                            int temp = miLista[i];
                            miLista[i] = miLista[i+1];
                            miLista[i + 1] = temp;
                            intercambio = true;
                        }

                    
                }

            } while (intercambio);

        }
    }
}
