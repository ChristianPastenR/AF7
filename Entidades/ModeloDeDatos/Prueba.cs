using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ModeloDeDatos
{
    class Prueba
    {
        Cargo entidades = null;

        public Cargo Entidades
        {
            get
            {
                if(entidades == null)
                    entidades = new Cargo();
                return entidades;

            }

        }
    }
}
