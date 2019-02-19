using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peleaCientifica
{
    public class classElecciones
    {
        public void elccionPersonaje()
        {
            classCombates Combate = new classCombates();
            Console.WriteLine("       COMBATE CIENTIFICO! \n");
            Console.WriteLine("--------------------------------");
            
            //  PLAYER
            Console.WriteLine("ELECCION DE PERSONAJE:");
            Console.WriteLine("1- Arquímides de Siracusa");
            Console.WriteLine("2- Leonardo da Vinci");
            Console.WriteLine("3- Nicolás Copérnico");
            Console.WriteLine("4- Galileo Galilei");
            Console.WriteLine("5- Isaac Newton");
            Console.WriteLine("6- Benjamin Franklin");
            Console.WriteLine("7- Louis Pasteur");
            Console.WriteLine("8- Nikola Tesla");
            Console.WriteLine("9- Albert Einstein");
            Console.WriteLine("10- Stephen Hawking");

            string personaje = Console.ReadLine();
            Console.WriteLine("\n");
            classCientificos player = new classCientificos();
            switch (personaje)
            {
                case "1":
                    Console.WriteLine("Has elegido a Arquímides de Siracusa");
                    Console.WriteLine("\n");
                    player.Cientifico("Arquímides de Siracusa", "Principio de Arquímides"
                        , "Ley de la palanca", "Tornillo de Arquímides", "Fuerza de empuje"
                        , 30, 40, 15, 15, 1000, 30);
                    break;
                case "2":
                    Console.WriteLine("Has elegido a Leonardo da Vinci");
                    Console.WriteLine("\n");
                    player.Cientifico("Leonardo da Vinci", "La ultima cena", "Los Engrajes", "La Gioconda", "La Escafandra", 60, 45, 65, 30, 900, 35);
                    break;
                case "3":
                    Console.WriteLine("Has elegido a Nicolás Copérnico");
                    Console.WriteLine("\n");
                    player.Cientifico("Nicolás Copérnico", "Los Tres Movimientos", "Alineación Planetaria", "Heliocéntrico", "Gregoriano", 99, 101, 35, 75, 800, 40);
                    break;
                case "4":
                    Console.WriteLine("Has elegido a Galileo Galilei");
                    Console.WriteLine("\n");
                    player.Cientifico("Galileo Galilei", "El Péndulo", "Telescopio", "Manchas Solares", "Lunas De Júpiter", 21, 110, 80, 34, 855, 45);
                    break;
                case "5":
                    Console.WriteLine("Has elegido a Isaac Newton");
                    Console.WriteLine("\n");
                    player.Cientifico("Isaac Newton", "Segunda Ley", "Gravitación Universal", "El Color ", "Velocidad Del Sonido", 8, 3, 7, 32, 1050, 70);
                    break;
                case "6":
                    Console.WriteLine("Has elegido a Benjamin Franklin");
                    Console.WriteLine("\n");
                    player.Cientifico("Benjamin Franklin", "Horno de Franklin", "El Pararrayos", "Corrientes Oceánicas", "Corriente Continua", 77, 66, 33, 22, 902, 55);
                    break;
                case "7":
                    Console.WriteLine("Has elegido a Louis Pasteur");
                    Console.WriteLine("\n");
                    player.Cientifico("Louis Pasteur", "Pasteurización", " Asimetría Cristalina", "La antirrábica ", "Germenes", 65, 99, 80, 14, 842, 85);
                    break;
                case "8":
                    Console.WriteLine("Has elegido a Nikola Tesla");
                    Console.WriteLine("\n");
                    player.Cientifico("Nikola Tesla", "Bobina de Telsa ", "Campo Magnético Rotativo", "Rayos X ", "Corriente Alterna", 200, 40, 31, 30, 799, 50);
                    break;
                case "9":
                    Console.WriteLine("Has elegido a Albert Einstein");
                    Console.WriteLine("\n");
                    player.Cientifico("Albert Einstein", "Espacio - Tiempo ", "Gps ", "Relatividad Especial", "Efecto Fotoeléctrico", 120, 33, 32, 22, 893, 65);
                    break;
                case "10":
                    Console.WriteLine("Has elegido a Stephen Hawking");
                    Console.WriteLine("\n");
                    player.Cientifico("Stephen Hawking", "Agujero Negro", "Radiación de Hawking", "Big Bang ", "Singularidades Espaciotemporales", 63, 88, 93, 101, 755, 99);
                    break;
                default:
                    break;
            }


            //  PC
            Console.WriteLine("ELECCION DE ENEMIGO:");

            Console.WriteLine("1- Arquímides de Siracusa");
            Console.WriteLine("2- Leonardo da Vinci");
            Console.WriteLine("3- Nicolás Copérnico");
            Console.WriteLine("4- Galileo Galilei");
            Console.WriteLine("5- Isaac Newton");
            Console.WriteLine("6- Benjamin Franklin");
            Console.WriteLine("7- Louis Pasteur");
            Console.WriteLine("8- Nikola Tesla");
            Console.WriteLine("9- Albert Einstein");
            Console.WriteLine("10- Stephen Hawking");
            personaje = Console.ReadLine();
            Console.WriteLine("\n");
            classCientificos pc = new classCientificos();

            

            switch (personaje)
            {
                case "1":
                    Console.WriteLine("Tu enemigo es Arquímides de Siracusa");
                    Console.WriteLine("\n");
                    pc.Cientifico("Arquímides de Siracusa", "Principio de Arquímides"
                        , "Ley de la palanca", "Tornillo de Arquímides", "Fuerza de empuje"
                        , 30, 40, 15, 15, 1000, 30);
                    break;
                case "2":
                    Console.WriteLine("Tu enemigo es Leonardo da Vinci");
                    Console.WriteLine("\n");
                    pc.Cientifico("Leonardo da Vinci", "La ultima cena", "Los Engrajes", "La Gioconda", "La Escafandra", 60, 45, 65, 30, 900, 35);
                    break;
                case "3":
                    Console.WriteLine("Tu enemigo es Nicolás Copérnico");
                    Console.WriteLine("\n");
                    pc.Cientifico("Nicolás Copérnico", "Los Tres Movimientos", "Alineación Planetaria", "Heliocéntrico", "Gregoriano", 99, 101, 35, 75, 800, 40);
                    break;
                case "4":
                    Console.WriteLine("Tu enemigo es Galileo Galilei");
                    Console.WriteLine("\n");
                    pc.Cientifico("Galileo Galilei", "El Péndulo", "Telescopio", "Manchas Solares", "Lunas De Júpiter", 21, 110, 80, 34, 855, 45);
                    break;
                case "5":
                    Console.WriteLine("Tu enemigo es Isaac Newton");
                    Console.WriteLine("\n");
                    pc.Cientifico("Isaac Newton", "Segunda Ley", "Gravitación Universal", "El Color ", "Velocidad Del Sonido", 8, 3, 7, 32, 1050, 70);
                    break;
                case "6":
                    Console.WriteLine("Tu enemigo es Benjamin Franklin");
                    Console.WriteLine("\n");
                    pc.Cientifico("Benjamin Franklin", "Horno de Franklin", "El Pararrayos", "Corrientes Oceánicas", "Corriente Continua", 77, 66, 33, 22, 902, 55);
                    break;
                case "7":
                    Console.WriteLine("Tu enemigo es Louis Pasteur");
                    Console.WriteLine("\n");
                    pc.Cientifico("Louis Pasteur", "Pasteurización", " Asimetría Cristalina", "La antirrábica ", "Germenes", 65, 99, 80, 14, 842, 85);
                    break;
                case "8":
                    Console.WriteLine("Tu enemigo es Nikola Tesla");
                    Console.WriteLine("\n");
                    pc.Cientifico("Nikola Tesla", "Bobina de Telsa ", "Campo Magnético Rotativo", "Rayos X ", "Corriente Alterna", 200, 40, 31, 30, 799, 50);
                    break;
                case "9":
                    Console.WriteLine("Tu enemigo es Albert Einstein");
                    Console.WriteLine("\n");
                    pc.Cientifico("Albert Einstein", "Espacio - Tiempo ", "Gps ", "Relatividad Especial", "Efecto Fotoeléctrico", 120, 33, 32, 22, 893, 65);
                    break;
                case "10":
                    Console.WriteLine("Tu enemigo es Stephen Hawking");
                    Console.WriteLine("\n");
                    pc.Cientifico("Stephen Hawking", "Agujero Negro", "Radiación de Hawking", "Big Bang ", "Singularidades Espaciotemporales", 63, 88, 93, 101, 755, 99);
                    break;
                default:
                    break;
            }

            Combate.Pelea(player, pc);
            Console.WriteLine();
        }
    }
}
