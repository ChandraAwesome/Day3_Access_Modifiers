using Learning_with_oops;

using static Learning_with_oops.Polymorphism;
namespace Learning_with_oops
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Constructer obj = new Constructer("tata");
            // Console.WriteLine(obj.Car);

            // Constructer.Animals animal = new Constructer.Animals();
            // Inheritance_Animals.Sounds();
            // Console.WriteLine(animal.Species + "\n" + animal.Breed);

            // Polymorphism one = new Polymorphism();
            // innherit two = new innherit();
            // Poly three= new Poly();

            // one.Oops();
            // two.Oops();
            // three.Oops();

            // abc a = new abc();
            // a.method();
            // a.method2();

            // onee d = new onee();
            // d.method1();
            // d.method2();

            //TypesofVariables result= new TypesofVariables();
            // result.TypesofVariabless();

            //  ValueType_ReferenceType.Value();
            //ReferenceType change = new ReferenceType("Ajay");

            //Console.WriteLine(change.value);

            //Kaksha objj = new Kaksha(); // calling static constructer
            //objj.normalmethod();

            Kaksha.x = 500;
            Kaksha.PrivateMethod();
        }
    }

}