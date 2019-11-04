using System.Collections.ObjectModel;
using System.Windows;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();


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
            alumnos.Add(new Alumno("jose", 7.2f, 4));
            alumnos.Add(new Alumno("lilian", 2.3f, 1));
            alumnos.Add(new Alumno("ana", 9.0f, 2));
            alumnos.Add(new Alumno("mara", 6.4f, 0));
            alumnos.Add(new Alumno("jojo", 8.9f, 9));
            alumnos.Add(new Alumno("jjo", 8f, 9));


            lstnumeros.ItemsSource = alumnos;
            //lstnumeros.ItemsSource = miLista;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //variable temporal, estos haran que se intercambien los valores, no se tiene que refrescar porque solo es un cambio de lugar.
            /*var temp = miLista[0]; 
            miLista[0] = miLista[3];
            miLista[3] = temp;*/

            int gab, i, j;
            gab = miLista.Count / 2; //el numero de elementos entre dos


            while (gab > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {



                    //utilizar otra lista, y cuando se evaluen no se hace directo de la lista, si un valor/propiedad de la lsta.
                    if (gab + i < alumnos.Count && alumnos[i].Faltas > alumnos[gab + i].Faltas)// un string no puede usar el <>
                    {
                        var temp = alumnos[i];

                        alumnos[i] = alumnos[gab + i];

                        alumnos[gab + i] = temp;//var, variable de tipo implicita

                    }


                }
                gab--; //restar uno 
            }

        }



        private void BtnBubble_Click(object sender, RoutedEventArgs e)
        {

            //bubble

            bool intercambio = false;
            do
            {
                
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++) //i++ para modificar el valor de la i, peor solo se le quiere sumar 1
                {

                    if (alumnos[i].Faltas > alumnos[i+1].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }


                }

            } while (intercambio);

        }

        private void Btnordenarnombres_Click(object sender, RoutedEventArgs e)
        {
            int gab, i, j;
            gab = alumnos.Count / 2; //el numero de elementos entre dos


            while (gab > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {

                    //utilizar otra lista, y cuando se evaluen no se hace directo de la lista, si un valor/propiedad de la lsta.
                    if (gab + i < alumnos.Count && alumnos[i].Promedio > alumnos[gab + i].Promedio)// un string no puede usar el <>
                    {
                        var temp = alumnos[i];

                        alumnos[i] = alumnos[gab + i];

                        alumnos[gab + i] = temp;//var, variable de tipo implicita

                    }


                }
                gab--; //restar uno 
            }
        }

        private void Btnbubblepromedio_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {

                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++) //i++ para modificar el valor de la i, peor solo se le quiere sumar 1
                {

                    if (alumnos[i].Promedio > alumnos[i + 1].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }


                }

            } while (intercambio);
        }

        private void Btnshell_mas_Click(object sender, RoutedEventArgs e)
        {
            int gab, i, j;
            gab = alumnos.Count / 2; //el numero de elementos entre dos


            while (gab > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {

                    //utilizar otra lista, y cuando se evaluen no se hace directo de la lista, si un valor/propiedad de la lsta.
                    if (gab + i < alumnos.Count && alumnos[i].Promedio > alumnos[gab + i].Promedio)// un string no puede usar el <>
                    {
                        var temp = alumnos[i];

                        alumnos[i] = alumnos[gab + i];

                        alumnos[gab - i] = temp;//var, variable de tipo implicita

                    }


                }
                gab--; //restar uno 
            }
        }
    }
}
