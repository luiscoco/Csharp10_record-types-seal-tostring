Person persona = new Person();
persona.FirstName = "Luis";
persona.LastName = "Coco Enriquez";
string result = persona.ToString();
Console.WriteLine(result);

//Student student = new Student();

public record Person
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    //IMPORTANT!!! see the "sealed" keyword in the "ToString" method
    //IMPORTANT!!! C# 10 : Record types can seal toString() method
    public sealed override string ToString()
    {
        return $"My name is: {FirstName} {LastName}";
    }
}

//public record Student : Person
//{
//    public override string ToString() // Error CS0239 'Student.ToString()': cannot override inherited member 'Person.ToString()' because it is sealed
//    {
//        return $"My name is {FirstName} {LastName}";
//    }
//}
