using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //clase padre
    {
        protected string Nombre; //atributos declaradas para ser usadas mas adelante
        protected string FechadeN;
        protected int Edad;
        protected string RangoEjecutivo;

        public string nombre //Caja de memoria y se ocupa otra nombreclatura en lugar de poner Nombre como se declara se pone nombre por qué si no nos marca error por qué está leyendo lo mismo
        {
            get { return Nombre; } //return es para regresar aquí si se ocupa la nomenclatura que ocupamos al inicio
            set { Nombre = value; } //se le otorga un valor
        }
        public string fechaden //caja de memoria
        {
            get { return FechadeN; } //return es para regresar
            set { FechadeN = value; }//se le otorga un valor (el get y set es un constructor)
        }
        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }
        
        public string rangoejecutivo 
        {
            get { return RangoEjecutivo; }
            set { RangoEjecutivo = value; }
        }
//sin la clase persona_herencia no haría la función de leer lo que el el usuario ingresa, aquí solo se declara lo básico que te piden, que normalmente es nuestro nombre, edad, fecha de nacimiento y si eres empleado 

        
    }

    class Alumno :Persona //clase hija alumno (caja de memoria donde se le da un valor y retorna el valor)
    {
        protected int Matricula; //variable
        protected string Carrera;
        public int matricula 
        {
            get { return Matricula; }
            set { Matricula = value; }
        }
        public string carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        public Alumno(string Nombre,int Edad, string FechadeN, string Carrera, int Matricula)
        {
            nombre = Nombre;
            edad = Edad;    
            fechaden = FechadeN;
            matricula = Matricula;
            carrera = Carrera;
        }
    }
    class Trabajador : Persona //clase hija que se llama empleado y solicita el sueldo que gana y se una una variable int por qué se ingresan valores numéricos 
    {
        protected float SueldoBase; //variable

        public float sueldobase
        {
            get { return SueldoBase; }
            set { SueldoBase = value; }
        }
        public Trabajador(string Nombre, int Edad, string FechadeN, string RangoEjecutivo, float SueldoBase)
        {
            nombre = Nombre;
            edad = Edad;
            fechaden = FechadeN;
            rangoejecutivo = RangoEjecutivo;
            sueldobase = SueldoBase;
        }
     
    }

    class Maestro: Persona //clase Hija dónde lo que realizar es igual guardar el sueldo que el usuario este ingresando 
    {
        protected float SueldoBase;
        public float sueldobase
        {
            get { return SueldoBase; }
            set { SueldoBase = value; }
        }
        public Maestro (string Nombre, int Edad, string FechadeN,string RangoEjecutivo, float SueldoBase)
        {
            nombre = Nombre;
            edad = Edad;
            fechaden = FechadeN;
            rangoejecutivo = RangoEjecutivo;
            sueldobase = SueldoBase;
        }

    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
