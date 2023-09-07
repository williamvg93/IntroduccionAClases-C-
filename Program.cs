using System.Collections;
using System.Reflection.Metadata;
using IntroduccionAClases.Entities;
ArrayList studentList = new ArrayList();
Student student = new Student();
int contStu;
int cont = 0;
Console.WriteLine("Enter the Number of student to ADD: ");
contStu = Convert.ToInt16(Console.ReadLine());
while (cont < contStu)
{
    student.Id = Guid.NewGuid().ToString();
    Console.WriteLine("Enter the Name: ");
    student.Name = Console.ReadLine();
    Console.WriteLine("Enter the email");
    student.Email = Console.ReadLine();
    Console.WriteLine("Enter the Age");
    student.Age = Convert.ToInt16(Console.ReadLine());
    ArrayList studentData = student.NewStuData();
    studentList.Add(studentData);
    cont++;
}
/*         Console.WriteLine(student.GetAllData()); */
/*         foreach (string dataStudent in student.GetAllData())
        {
            Console.Write($"{dataStudent} \t");
        } */
/*         Console.WriteLine();
        Console.WriteLine("\n"+student.NewStuData()); */


/*         foreach (string dStudent in studentData)
        {
            Console.Write($"{dStudent} \t");
        } */
ArrayList datosSt = new ArrayList();
Console.WriteLine($"longitus del la lista : {studentList.Count}");

for (int i = 0; i < studentList.Count; i++) {
    foreach (var element in (ArrayList)studentList[i])
    {
    Console.Write($"{element} \t");
    }
    Console.WriteLine();
}


/*     datosSt = (ArrayList)studentList[i];
    Console.WriteLine(datosSt); */
    
/*     for (int e = 0; e < datosSt.Count; e++)
    Console.Write($"{datosSt[e]} \t"); */

