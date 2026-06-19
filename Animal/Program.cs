using System.Runtime.InteropServices.Marshalling;

public class Program
{
    public static void Main()
    {
        List<Animal> myAnimals = new List<Animal> ();
        Animal myAnimal = new Animal("Liger");
        myAnimal.MakeNoise();
    }
}