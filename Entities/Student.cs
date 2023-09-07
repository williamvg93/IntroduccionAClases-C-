/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; */

using System.Collections;

namespace IntroduccionAClases.Entities;

public class Student
{
    /* public int Id { get; set;} */
    private string id;
    /* private int ? id { get; set; } */
    private string name;
    private string email;
    private int age;

    /* Propiedades de Clase */
    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Student(){

    }
    /* Contructor */
    public Student(string id, string name, string email, int age){
        this.id = id;
        this.name = name;
        this.email = email;
        this.age = age;
    }

    public Array GetAllData(){
        string[] numeros = {id, name, email, Convert.ToString(age)};
        return numeros; 
    }

    public ArrayList NewStuData(){
        ArrayList newStud = new ArrayList(){
            id,
            name,
            age,
            email
        };
        return newStud;
    }

}
