using System;

namespace WpfApp1
{
    internal class Properties
    {
        public static object Settings { get; internal set; }
        public static string Default { get; internal set;}
  
    }
}
public class Person
{
    private string Login;

    public Person(string name) =>  Login = name;

    // Person has one method, called WriteName.
    public void WriteName()
    {
        System.Console.WriteLine(Login);
    }

    internal void DisplayName()
    {
        throw new NotImplementedException();
    }
}

public class Program
{
    public static void Main()
    {
        var p = new Person("PersonName");

        // The following call fails because Person does not have
        // a method called DisplayName.
        p.DisplayName(); // CS1061
    }
}