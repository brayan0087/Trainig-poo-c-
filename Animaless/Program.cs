using System;

namespace Animaless
{
    class Program
    {
        static void Main(string[] args)
        {
            Lagartija l1 = new Lagartija();

            l1.getNombre("lagarti");
            l1.respirar();

            Ballena b1 = new Ballena();

            b1.getNombre("ball");
            b1.nadar();
            b1.pensar();
            b1.respirar();

            Caballo c1 = new Caballo();
            c1.galopar();


            Humano h1 = new Humano();

            h1.pensar();

            //se instancian las clases y se llaman sus metodos propios y heredados 

        }


    }


    interface IMamiferosTerrestres //interface para que se obligue a implementar el metodo numero patas
    {
        void numeroPatas();
    }

    public abstract class Animales  //clase abstracta es la clase con menos abstraccion 
    {
        public void respirar()
        {

            Console.WriteLine("Estoy respirando...");
        }



        public abstract void getNombre(string nombre); //si hay un metodo abstracto la clase tiene que ser abstracta 
        

    }


    public class Lagartija :Animales
    {

        public override void getNombre(string nombre) //si la clase hereda de una clase abstracta tiene que implementar el metodo abstracto 
        {

            Console.WriteLine("Soy un lagarto");

        }
    }


    public class Mamiferos:Animales
    {
         

        
        public override void getNombre(string nombre)
        {
            Console.WriteLine("Mi nombre es: " + nombre); //si la clase hereda de una clase abstracta tiene que implementar el metodo abstracto 
        }
      

        public void pensar()
        {
            Console.WriteLine("estoy pensando");
        }

    }


    public class Ballena : Mamiferos
    {

        public void nadar()
        {
            Console.WriteLine("estoy nadando");
        }

    }

    public class  Caballo : Mamiferos,IMamiferosTerrestres  //implementa la interfaz por lo cual tiene que cumplir el contrato de numeroPatas();
    {

        public void galopar()
        {
            Console.WriteLine("estoy galopando");
        }

        public void numeroPatas()
        {
            Console.WriteLine("Tengo 4 patas");
        }

    }


    public class Humano : Mamiferos, IMamiferosTerrestres //implementa la interfaz por lo cual tiene que cumplir el contrato de numeroPatas();
    {

        new public void pensar() //el humano piensa de una forma diferente asi que se usa el new para modificar el metodo heredado
        {
            Console.WriteLine("estoy pensando de otra forma");
        }

        public void numeroPatas()
        {
            Console.WriteLine("Tengo 2 pies");
        }

    }



    public class gorilla : Mamiferos, IMamiferosTerrestres //implementa la interfaz por lo cual tiene que cumplir el contrato de numeroPatas();
    {

         public void trepar()
        {
            Console.WriteLine("estoy trepando");
        }


        public void numeroPatas()
        {
            Console.WriteLine("Tengo 4 patas");
        }

    }



}
