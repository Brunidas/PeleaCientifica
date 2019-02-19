using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peleaCientifica
{
    public class classCientificos
    {
        public string Nombre, NombreAtaque1, NombreAtaque2, NombreAtaque3, NombreAtaque4;
        public int Ataque1,Ataque2,Ataque3,Ataque4, Vida, Velocidad;

        public void Cientifico(string pNombre,string pNombreAtaque1,string pNombreAtaque2 
            ,string pNombreAtaque3,string pNombreAtaque4, int pAtaque1,
            int pAtaque2, int pAtaque3,int pAtaque4, int pVida, int pVelocidad)
        {
            this.Nombre = pNombre;
            this.NombreAtaque1 = pNombreAtaque1;
            this.NombreAtaque2 = pNombreAtaque2;
            this.NombreAtaque3 = pNombreAtaque3;
            this.NombreAtaque4 = pNombreAtaque4;
            this.Ataque1 = pAtaque1;
            this.Ataque2 = pAtaque2;
            this.Ataque3 = pAtaque3;
            this.Ataque4 = pAtaque4;
            this.Vida = pVida;
            this.Velocidad = pVelocidad; 
        }

    }
}
