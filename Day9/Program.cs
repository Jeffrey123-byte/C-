using System;
// using System.Drawing;
// using System.Windows.Forms;

// public class MyForm : Form
// {
//     // The control variables are declared here
//     private Label label1; // This will be the "Name" label from your code, now for Number 1
//     private Label label2; // This will be the "Age" label from your code, now for Number 2
//     private TextBox textBox1; // The first number input
//     private TextBox textBox2; // The second number input
//     private Button button1; // The "Submit" button, now "Add Numbers"
//     private TextBox textBox3; // The result output textbox

//     public MyForm()
//     {
//         // This section replaces the "InitializeComponent()" code.
//         // We are manually setting up the controls and their properties.
        
//         // Set up the form itself
//         this.Text = "Simple Adder";
//         this.Size = new Size(320, 250);
//         this.StartPosition = FormStartPosition.CenterScreen;
//         this.Font = new Font("Sans-Serif", 10);
        
//         // --- Creating and configuring controls based on your provided layout ---

//         // Label for the first number
//         this.label1 = new System.Windows.Forms.Label();
//         this.label1.AutoSize = true;
//         this.label1.Location = new System.Drawing.Point(20, 40);
//         this.label1.Text = "Number 1:";
//         this.Controls.Add(this.label1);

//         // TextBox for the first number
//         this.textBox1 = new System.Windows.Forms.TextBox();
//         this.textBox1.Location = new System.Drawing.Point(120, 36);
//         this.textBox1.Size = new System.Drawing.Size(150, 22);
//         this.Controls.Add(this.textBox1);
        
//         // Label for the second number
//         this.label2 = new System.Windows.Forms.Label();
//         this.label2.AutoSize = true;
//         this.label2.Location = new System.Drawing.Point(20, 80);
//         this.label2.Text = "Number 2:";
//         this.Controls.Add(this.label2);
        
//         // TextBox for the second number
//         this.textBox2 = new System.Windows.Forms.TextBox();
//         this.textBox2.Location = new System.Drawing.Point(120, 76);
//         this.textBox2.Size = new System.Drawing.Size(150, 22);
//         this.Controls.Add(this.textBox2);

//         // Button to perform the addition
//         this.button1 = new System.Windows.Forms.Button();
//         this.button1.Location = new System.Drawing.Point(120, 120);
//         this.button1.Size = new System.Drawing.Size(150, 30);
//         this.button1.Text = "Add Numbers";
//         this.button1.UseVisualStyleBackColor = true;
//         // Attach the event handler
//         this.button1.Click += new System.EventHandler(this.button1_Click);
//         this.Controls.Add(this.button1);
        
//         // TextBox to display the result
//         this.textBox3 = new System.Windows.Forms.TextBox();
//         this.textBox3.Location = new System.Drawing.Point(20, 170);
//         this.textBox3.Size = new System.Drawing.Size(250, 22);
//         this.textBox3.ReadOnly = true; // Make it read-only since it's an output field
//         this.Controls.Add(this.textBox3);
//     }

//     // The event handler for the button click, now with the addition logic.
//     private void button1_Click(object sender, EventArgs e)
//     {
//         try
//         {
//             // Get the text from the two input text boxes
//             if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
//             {
//                 textBox3.Text = "Error: Please enter both numbers.";
//                 return;
//             }

//             // Convert the text to integers and perform the addition
//             int num1 = int.Parse(textBox1.Text);
//             int num2 = int.Parse(textBox2.Text);
//             int sum = num1 + num2;

//             // Display the result in the output textbox
//             textBox3.Text = "Result: " + sum.ToString();
//         }
//         catch (FormatException)
//         {
//             // Handle the case where the user enters non-numeric text
//             textBox3.Text = "Error: Please enter valid numbers.";
//         }
//         catch (OverflowException)
//         {
//             // Handle the case where the number is too large for an int
//             textBox3.Text = "Error: One of the numbers is too large.";
//         }
//     }
    
//     // The main entry point for the application
//     [STAThread]
//     public static void Main()
//     {
//         Application.EnableVisualStyles();
//         Application.SetCompatibleTextRenderingDefault(false);
//         Application.Run(new MyForm());
//     }
// }

// public class Demo
// {
//     private static void Main(string[] args)
//     {
        
//         try
//         {
//             int n1 = 02;
//             int n2 = 0;

//             // This line will throw a DivideByZeroException because you cannot divide by zero.
//             int sum = n1 / n2;

//             // This line will not be reached because the exception is thrown before it.
//             Console.WriteLine(sum);
//         }
//         // It's best to catch specific exceptions and provide a helpful message.
//         catch (DivideByZeroException)
//         {
//             Console.WriteLine("Error: You cannot divide by zero.");
//         }
//         // A generic catch block can be used for other unexpected errors.
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An unexpected error occurred: {ex.Message}");
//         }
//     }
// }


using System;
using System.IO;

public class DirectoryManager
{
    // A helper method to create a directory and report the result.
    private static void EnsureDirectoryExistsAndReport(string path)
    {
        Console.WriteLine($"\nAttempting to create directory: '{path}'...");
        
        try
        {
            // Directory.CreateDirectory will create the directory if it doesn't exist.
            Directory.CreateDirectory(path);
            Console.WriteLine("Directory exists (or was just created successfully).");
        }
        catch (Exception ex)
        {
            // This will catch any issues like permission errors.
            Console.WriteLine($"Failed to create directory due to an error: {ex.Message}");
        }
    }

    public static void Main(string[] args)
    {
        // Get the path to the user's home directory.
        string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        // Build the full path for the first directory.
        string directoryPath = Path.Combine(userProfilePath, "Documents", "C#", "Day 9", "Kings");

        // Use the new simplified helper method.
        EnsureDirectoryExistsAndReport(directoryPath);
        
        // Let's demonstrate with the nested directory.
        string nestedPath = Path.Combine(userProfilePath, "Documents", "C#", "Day 9", "Kings", "Royalty", "ThroneRoom");
        
        // Use the same method for the nested path.
        EnsureDirectoryExistsAndReport(nestedPath);
    }
}
