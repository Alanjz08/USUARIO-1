using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    class Usuario
    {
        //Atributos - Campos 
        private string nombre;
        private string correo;
        private int numerodeSeguidores;

        //Metodos 
        public void publicar(string mensaje)
        {
            Console.WriteLine($"{nombre}, acaba de publicar lo siguiente: {mensaje}");
        } 

        public void VerPerfil()
        {
            Console.WriteLine($"User: {nombre} Correo:{correo} Seguidores: {numerodeSeguidores}");
        }

        public void setNombre( string nombre)
        {
            //TO DO: verificar que el nombre de usuario no exista
            this.nombre = nombre; //metodo para poder usar el nombre pero mientras esta encapsulado
        }
        public void setCorreo(string correo)
        {
            this.correo = correo;
        } 

        public void setSeguidores (int n)
        {
            if (n < 0)
                n = n * -1;
            numerodeSeguidores = n;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Usuario mario = new Usuario(); 

            //mario.setNombre="Mariosky"
            mario.setNombre("Mariosky");
            mario.setCorreo("mariosky.com");
            mario.setSeguidores(50);

            mario.VerPerfil();
            mario.publicar("Hola a todos!! uwu #OOP"); //Mensaje de la publicacion 
            Console.ReadKey();
        }
    }
}
