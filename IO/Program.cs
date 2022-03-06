Console.WriteLine("Hello, Welcome to HackerUs");
Console.WriteLine("Please enter first name");
string firstName = Console.ReadLine();
Console.WriteLine("Please enter last name");
string lastName = Console.ReadLine();
Console.WriteLine("Please enter date of birth");
int yearOfBirth = int.Parse(Console.ReadLine()); 


Console.Clear();
Console.Write("Welcome " + firstName + " " + lastName);
Console.WriteLine(" You are " + (2022 - yearOfBirth) +  " years old");


Console.WriteLine("Press any key to exit");
Console.ReadKey();

//Console.WriteLine("Please enter your first name:");
