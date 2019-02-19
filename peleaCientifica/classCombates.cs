using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peleaCientifica
{
    public class classCombates
    {
       
            // controla todo el combate 
            int turno;

            public void Pelea(classCientificos player, classCientificos pc)
            {
                // si esta variable esn TRUE significa que hay un combate
                bool pelea = true;

                int dannoRecibido = 0;
                int dannoInflingido = 0;
                // comparo cual de los personajes tiene mas velocidad, el mas rapido es el primero

                if (player.Velocidad >= pc.Velocidad)
                {
                    Console.WriteLine(player.Nombre + " empieza el combate!");
                    turno = 1;
                }
                else if (pc.Velocidad > player.Velocidad)
                {
                    Console.WriteLine(pc.Nombre + " empieza el combate!");
                }

                //   Aqui comienza la pelea
                while (pelea == true)
                {
                    if (turno == 1)
                    {
                        // si turno = 1, le toca jugar al player
                        Console.WriteLine("Es el turno de " + player.Nombre + "\nTu vida es de: " + player.Vida);
                        Console.WriteLine("¿Qué hablidad usaras?");
                        Console.WriteLine("1- " + player.NombreAtaque1);
                        Console.WriteLine("2- " + player.NombreAtaque2);
                        Console.WriteLine("3- " + player.NombreAtaque3);
                        Console.WriteLine("4- " + player.NombreAtaque4);
                        string LecturaAtaque = Console.ReadLine();
                        switch (LecturaAtaque)
                        {
                            case "1":
                                dannoInflingido = pc.Vida - player.Ataque1;
                                pc.Vida = dannoInflingido;
                                break;
                            case "2":
                                dannoInflingido = pc.Vida - player.Ataque2;
                                pc.Vida = dannoInflingido;  
                                break;
                            case "3":
                                dannoInflingido = pc.Vida - player.Ataque3;
                                pc.Vida = dannoInflingido;
                                break;
                            case "4":
                                dannoInflingido = pc.Vida - player.Ataque4;
                                pc.Vida = dannoInflingido;
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("Daño Inflinjido: "+ dannoInflingido+"\n");
                        Console.WriteLine("A " + player.Nombre + " le queda " + player.Vida + " puntos de vida");
                        Console.WriteLine("A " + pc.Nombre + " le queda " + pc.Vida + " pintos de vida \n");
                        turno = 0;

                    }
                    else if (turno == 0)
                    // si turno = 0, le toca jugar al pc
                    {
                        Random r = new Random();
                        int num = r.Next(1, 5);
                        string tex = num.ToString();


                        switch (tex)
                        {
                            case "1":
                                dannoRecibido = pc.Vida - player.Ataque1;
                                pc.Vida = dannoRecibido;
                                break;
                            case "2":
                            dannoRecibido = pc.Vida - player.Ataque2;
                            pc.Vida = dannoRecibido;
                            break;
                            case "3":
                            dannoRecibido = pc.Vida - player.Ataque3;
                            pc.Vida = dannoRecibido;
                            break;
                            case "4":
                            dannoRecibido = pc.Vida - player.Ataque4;
                            pc.Vida = dannoRecibido;
                            break;
                            default:
                                break;
                        }
                        Console.WriteLine("Daño recibido: " + dannoRecibido +"\n");
                        Console.WriteLine("\nA " + player.Nombre + " le queda " + player.Vida + " puntos de vida");
                        Console.WriteLine("A " + pc.Nombre + " le queda " + pc.Vida + " pintos de vida \n");
                        turno = 1;
                    }

                    if (player.Vida <= 0)
                    {
                        Console.WriteLine("PELEA TERMINADO");
                        Console.WriteLine(pc.Nombre + " ha ganado");
                        pelea = false;
                        break;
                    }
                    else if (pc.Vida <= 0)
                    {
                        Console.WriteLine("HAS GANADO!");
                        Console.WriteLine(player.Nombre +" ha ganado");
                        pelea = false;
                        break;
                    }


                }
              
            }
        
    }
}
