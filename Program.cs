using IntroduccionAClases.Entities;
internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();
        student.Id = 125;
        Console.WriteLine("Enter the Name: ");
        student.Name = Console.ReadLine();
        Console.WriteLine("Enter the email");
        student.Email = Console.ReadLine();
        Console.WriteLine("Enter the Age");
        student.Age = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(student.GetAllData());
        foreach (string dataStudent in student.GetAllData())
        {
            Console.WriteLine(dataStudent);
        }
    }
}