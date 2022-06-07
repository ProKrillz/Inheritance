using Inheritance;
class Program {
    public static void Main(String[] args) {


        List<Student> list = new List<Student>();
        list.Add(new Student { Name = "Thomas", Age = 33, ClassNumber = "2B"});
        list.Add(new Student { Name = "Nikolaj", Age = 19, ClassNumber = "1A" });
        list.Add(new Student { Name = "Adrian", Age = 8, ClassNumber = "0C" });
        list.Add(new Student { Name = "Brian", Age = 27, ClassNumber = "9B" });
        foreach (Student item in list)
        {
            Console.WriteLine($"Name: {item.Name}\nAge: {item.Age}\nClass number: {item.ClassNumber}\n");
        }

    }
}
