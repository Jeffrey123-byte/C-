using System;

public class Class1
{
	public Class1()
	{
        string name = "Jeffrey";
        Console.WriteLine(name);
        string[] FirstName = new string[] { name };
        Console.WriteLine(FirstName[0]);
        Console.ReadLine();
        // Now FirstName contains one element: "Jeffrey"
    }
}
