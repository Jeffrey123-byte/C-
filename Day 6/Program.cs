// public class Demo
// {
//     static int Add(int a, int b)
//     {
//        return a + b;
//     }
//     static void Main(String[] args)
//     {
//         int a = Demo.Add(5, 6);
//         Console.WriteLine(a);

//     }

// }

// class Dog
// {
//     private string name= "Jeffy";//Class instances
//     string breed;
//     int age;

//     // Behaviors (methods)
//     void bark()//behaviours or methods
//     {
//         Console.WriteLine("Woof woof");
//         Console.WriteLine(name);// instance execution
//         // code to make the dog bark
//     }

//     void wagTail()
//     {
//         Console.WriteLine("Wagging tail");
//         // code to make the dog wag its tail
//     }

//     private static void Main(String[] args)
//     {
//         Dog d = new Dog();//objects
//         d.bark();
//         d.wagTail();
//     }
// }

// public: The front door to your house. Anyone can access it.

// private: Your personal diary. Only you can access it.

// protected: The rules of your family. Only family members (your class and its children) need to know them.

//Consturctors : A constructor is a special method that is automatically called when a new object is created. 

// using System;

// class Person {
//     public string name;
//     public int age;

//     // Constructor with two parameters
//     public Person(string name, int age) {
//         this.name = name;
//         this.age = age;
//     }
// }

// public class MainClass // Don't name it 'Main' — that's confusing
// {
//     public static void Main(string[] args)
//     {
//         Person john = new Person("John Doe", 30); // Calls the constructor
        
//         Console.WriteLine($"Name: {john.name}, Age: {john.age}");
//     }
// }

using System;

class Dog
{
    // Private fields
    private string name;
    private int age;

    // Constructor to initialize the object
    public Dog(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Public getter for name
    public string GetName()
    {
        return this.name;
    }

    // Public setter for age with validation
    public void SetAge(int newAge)
    {
        if (newAge > 0)
        {
            this.age = newAge;
        }
        else
        {
            Console.WriteLine("Age must be a positive number.");
        }
    }

    // Optional: Getter for age if you want to check it
    public int GetAge()
    {
        return this.age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy", 5);

        // This is an invalid action because 'age' is private
        // myDog.age = -1; // Uncommenting this line would cause a compile-time error

        // Correct, safe way to update the age
        myDog.SetAge(6);   // This will work
        myDog.SetAge(-1);  // This will trigger the validation message

        // Output the dog's name and age
        Console.WriteLine($"Dog's name: {myDog.GetName()}");
        Console.WriteLine($"Dog's age: {myDog.GetAge()}");
    }
}

