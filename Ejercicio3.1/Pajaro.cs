using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3._1
{
    class Pajaro
    {
        private bool hambriento;
        private bool sediento;
        private int edad;
        private int peso;
        private int altura;
        private int envergadura;
        private string especie;

        public int GetEdad()
        {
            return this.edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int GetPeso()
        {
            return this.peso;
        }
        public void SetPeso(int peso)
        {
            this.peso = peso;
        }
        public int GetAltura()
        {
            return this.altura;
        }
        public void SetAltura(int altura)
        {
            this.altura = altura;
        }
        public int GetEnvergadura()
        {
            return this.envergadura;
        }
        public void SetEnvergadura(int envergadura)
        {
            this.envergadura = envergadura;
        }
        public bool GetSediento()
        {
            return this.sediento;
        }
        public void SetSediento(bool sediento)
        {
            this.sediento = sediento;
        }
        public bool GetHambriento()
        {
            return this.hambriento;
        }
        public void SetHambriento(bool hambriento)
        {
            this.hambriento = hambriento;
        }
        public string GetEspecie()
        {
            return this.especie;
        }
        public void SetEspecie(string especie)
        {
            this.especie = especie;
        }
        public void Comer()
        {
            if(GetHambriento())
            {
                this.SetHambriento(false);
            }
        }
        public void Tomar()
        {
            if (GetSediento())
            {
                this.SetSediento(false);
            }
        }
    }
}
