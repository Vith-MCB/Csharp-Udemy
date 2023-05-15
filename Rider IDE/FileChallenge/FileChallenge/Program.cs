#region Variables and constants

const string filepath =
    @"D:\Programação\GitHub\Csharp-Udemy\Rider IDE\FileChallenge\FileChallenge\files\input.txt";

const string outputfile = 
    @"D:\Programação\GitHub\Csharp-Udemy\Rider IDE\FileChallenge\FileChallenge\files\output.txt";

//Defining the text vector (Line by line)
string[] lines = File.ReadAllLines(filepath);

string result = "";
    
#endregion

#region Main

foreach (string str in lines)
{
    if (FindSplit(str))
    {
        string[] splitParts = str.Split(' ');
        if (result == ""){result += splitParts[4];} 
        else { result += " " + splitParts[4]; }
        
    }
}

File.WriteAllText(outputfile,result);

#endregion


#region Functions

bool FindSplit(string input)
{
    var targetWord = "split";
    var position = input.IndexOf(targetWord, StringComparison.OrdinalIgnoreCase);

    if (position != -1) {return true;}
    else { return false; }
}

#endregion
