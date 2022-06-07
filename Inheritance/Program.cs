using Inheritance;
class Program {
    public static void Main(String[] args) {

        Student elev1 = new Student { Name = "Thomas", Age = 33, ClassNumber = "b2"};
        Console.WriteLine(elev1.PrintPerson());
    }
}
