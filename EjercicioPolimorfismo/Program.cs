// Clase base o superclase
public abstract class Animal
{
    public abstract void Sonido();
}

// Clase hija o subclase
public class Perro : Animal
{
    public override void Sonido()
    {
        Console.WriteLine("El perro hace: guau guau");
    }
}

// Clase hija o subclase
public class Gato : Animal
{
    public override void Sonido()
    {
        Console.WriteLine("El gato hace: miau miau");
    }
}

// Clase principal
class Program
{
    static void Main(string[] args)
    {
        Animal miPerro = new Perro(); // Crear un objeto Perro
        Animal miGato = new Gato(); // Crear un objeto Gato
        miPerro.Sonido(); // El perro hace: guau guau
        miGato.Sonido(); // El gato hace: miau miau
    }
}
