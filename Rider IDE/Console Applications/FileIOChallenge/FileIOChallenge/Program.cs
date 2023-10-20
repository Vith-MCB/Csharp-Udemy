#region READ

//Reading a file and store the entire file in a string var (Method 1)
string text = System.IO.File.ReadAllText(@"D:\Programação\GitHub\Csharp-Udemy\Rider IDE\FileIOChallenge\FileIOChallenge\textFile.txt");
Console.WriteLine("Text:\n{0}",text);

//Reading the same file and storing it in a string vector (Method 2)
string[] textVect = System.IO.File.ReadAllLines(@"D:\Programação\GitHub\Csharp-Udemy\Rider IDE\FileIOChallenge\FileIOChallenge\textFile.txt");
Console.WriteLine("\nSecond line:\n{0}",textVect[1]);

#endregion

#region WRITE

//Method 1
string[] lines = { "First Line", "Second line", "Third line" };

File.WriteAllLines(@"D:\Programação\GitHub\Csharp-Udemy\Rider IDE\FileIOChallenge\FileIOChallenge\textFile.txt",lines);

//Method 2
Console.WriteLine("Please give the filename: ");
string fileName = Console.ReadLine();

Console.WriteLine("Input: ");
string input = Console.ReadLine();

File.WriteAllText(@"D:\Programação\GitHub\Csharp-Udemy\Rider IDE\FileIOChallenge\FileIOChallenge\"+fileName+".txt",input);

#endregion

