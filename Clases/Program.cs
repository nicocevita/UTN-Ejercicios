using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Asignados
    {
        private Persona persona = null;

        public Persona Personas
        {
            get { return persona; }
            set { persona = value; }
        }

        private Persona[] persona;
        public Persona[] Personas
        {
            get
            {
                if (personas.Length == 0) return null;
                else return Personas;
            }
            set
            {
                Personas = value;
            }

        }

        private Auto auto = null;

        public Auto Auto
        {
            get { return auto; }
            set { auto = value; }

        }

        private Auto[] autos;

        public Auto[] Autos
        {
            get
            {
                if (autos.Length == 0) return null;
                else return auto;
            }
            set
            {
                autos = value;
            }
        }

        public Asignados (Persona p, Auto[] autos)
        {
            persona = p;
            this.autos = autos;
        }

        public Asignados (Auto a, Persona[] personas)
        {
            auto = a;
            this.Personas = personas;
        }
    }

}
