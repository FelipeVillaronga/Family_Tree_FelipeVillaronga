using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node luisAlberto = new Node(new Person("Luis Suarez", 35));
            Node robin = new Node(new Person("Robin Van Persie", 39));
            Node ivan = new Node(new Person("Ivan Alonso", 43));
            Node daniel = new Node(new Person("Daniel Sturridge", 33));
            Node elNiño = new Node(new Person("Fernando Torres", 38));
            Node didier = new Node(new Person("Didier Drogba", 44));
            Node mario = new Node(new Person("Mario Gomez", 37));
            Node mesut= new Node(new Person("Mesut Ozil", 34));

            luisAlberto.AddChildren(robin);
            luisAlberto.AddChildren(elNiño);

            robin.AddChildren(didier);
            mesut.AddChildren(mario);

            elNiño.AddChildren(daniel);
            elNiño.AddChildren(ivan);

            // visitar el árbol aquí

            INodesContent nodesAges= new AgeSummatoryContent(luisAlberto);
            Console.WriteLine(nodesAges.GetResult());

            INodesContent nodesNames= new LongestNameContent(luisAlberto);
            Console.WriteLine(nodesNames.GetResult());

            INodesContent nodesOldest= new OldestContent(luisAlberto);
            Console.WriteLine(nodesOldest.GetResult());
            
        }
    }
}
