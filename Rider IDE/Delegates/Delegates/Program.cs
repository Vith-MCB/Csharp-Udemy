//Using Delegates

List<string> names = new List<string>() {"Aiden", "Sif", "Walter", "Anatoli", "Ion"};

Console.WriteLine("----Before the Delegate----");
foreach (string name in names)
{
    Console.WriteLine(name);
}

names.RemoveAll(Filter);

static bool Filter(string str)
{
    //Return whether the string 'str' contains the letter 'i'
    //The '.Contains' method will return a bool which will be return
    string filterStr = "i";
    return str.ToLower().Contains(filterStr);

}

Console.WriteLine("----After the Delegate----");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Creating Delegates