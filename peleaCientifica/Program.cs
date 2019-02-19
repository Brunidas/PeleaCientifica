using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peleaCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            //   NUMEROS ALEATORIOS DEL 1 AL 4
            //Random r = new Random();
            //int num;
            //num = r.Next(1, 5);
            //string tex = num.ToString();
            //Console.WriteLine(tex);
            //Console.ReadKey();


            classElecciones eleccion = new classElecciones();
            classCombates combate = new classCombates();
            bool confirmacion = true;

            while (confirmacion == true)
            {
                eleccion.elccionPersonaje();
                Console.WriteLine("¿Desea seguir jugando?\n 1- Si\n 2- No");
                string SeguirJugandoTxt = Console.ReadLine();
                int SeguirJuagndoInt = Convert.ToInt32(SeguirJugandoTxt);

                if (SeguirJuagndoInt == 2)
                {
                    confirmacion = false;
                }

            }
        }
    }
}
