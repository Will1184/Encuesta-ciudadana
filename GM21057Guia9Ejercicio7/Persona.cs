using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM21057Guia9Ejercicio7
{
    internal class Persona
    {
        //DECLARACION DE VARIABLES
        int dui, altura, edad;
        string nombre, apellido, departamento;


        //CONSTRUCTIORES
        public Persona()
        {
        }

        public Persona(int dui, int altura, int edad, string nombre, string apellido, string departamento)
        {
            this.dui = dui;
            this.altura = altura;
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
            this.departamento = departamento;
        }

        //GETTERS Y SETTERS
        public int Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }

        //METODOS
        public void AgregarPersona(List<int> duis, List<int> edades, List<int> alturas, Persona persona)
        {

            duis.Add(persona.dui);
            edades.Add(persona.edad);
            alturas.Add(persona.altura);
        }
        public double PromedioAltura(double promedio, List<int> alturas, Persona persona)
        {
            promedio = (promedio+persona.altura)/ alturas.Count;
            return promedio;
        }

        public double PromedioEdades(double promedio,List<int> edades, Persona persona)
        {
           
            promedio = (promedio+persona.edad) / edades.Count;
            return promedio;
        }

    }
}
