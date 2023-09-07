using System.Collections;
using System.Reflection.Metadata;
using IntroduccionAClases.Entities;


/* ArrayList studentList = new ArrayList();

int contStu;
int cont = 0;
List<Student> studentList2 = new List<Student>();
Console.WriteLine("Enter the Number of student to ADD: ");
contStu = Convert.ToInt16(Console.ReadLine()); */
/* while (cont < contStu)
{
    Student student = new Student();
    student.Id = Guid.NewGuid().ToString();
    Console.WriteLine("Enter the Name: ");
    student.Name = Console.ReadLine();
    Console.WriteLine("Enter the email");
    student.Email = Console.ReadLine();
    Console.WriteLine("Enter the Age");
    student.Age = Convert.ToInt16(Console.ReadLine()); */

/*     Array  studentData =  student.GetAllData(); */
    /* ArrayList studentData = student.NewStuData(); */
/*     studentList.Add(studentData);
    cont++; */
/* } */


/* ArrayList datosSt = new ArrayList();
Console.WriteLine($"longitus del la lista : {studentList.Count}"); */

/* for (int i = 0; i < studentList.Count; i++) {
    foreach (var element in (ArrayList)studentList[i])
    {
    Console.Write($"{element} \t");
    }
    Console.WriteLine();
} */

/* for (int i = 0; i < studentList.Count; i++) {
    foreach (var element in (Array)studentList[i])
    {
    Console.Write($"{element} \t"); 
    }
    Console.WriteLine();
}  */

/* for (int i = 0; i < studentList.Count; i++) {
    foreach (var element in (Array)studentList[i])
    {
    Console.Write($"{element} \t"); 
    }
    Console.WriteLine();
}  */


int contStu;
int cont = 0;
List<Student> studentList = new List<Student>();
Console.WriteLine("Enter the Number of student to ADD: ");
contStu = Convert.ToInt16(Console.ReadLine());
while (cont < contStu)
{
    Student student = new Student();
    student.Id = Guid.NewGuid().ToString();
    Console.WriteLine("Enter the Name: ");
    student.Name = Console.ReadLine();
    Console.WriteLine("Enter the email");
    student.Email = Console.ReadLine();
    Console.WriteLine("Enter the Age");
    student.Age = Convert.ToInt16(Console.ReadLine());
    studentList.Add(student);
    cont++;
}

/* foreach (Student stud in studentList) 
{
    Console.WriteLine("{0,35} {1, -25} {2, -30} {3,4}", stud.Id, stud.Name, stud.Email, stud.Age);
} */


Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("{0,-35} {1, -25} {2, -30} {3,4}", "Id", "Name", "Email", "Age");

for (int i = 0; i < studentList.Count; i++)
{
    Console.WriteLine("{0,35} {1, -25} {2, -30} {3,4}", studentList[i].Id, studentList[i].Name, studentList[i].Email, studentList[i].Age);
}
