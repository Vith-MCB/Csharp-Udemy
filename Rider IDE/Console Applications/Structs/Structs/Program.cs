//Structs
//To use structs it must be initializated first, just like classes
car car1;
car1.name = "Gol";
car1.company = "Volkswagen";
car1.price = 52000;

car1.DisplayInfo();

//Structs DO NOT support inheritance
struct car{
    public string name;
    public string company;
    public double price;

    public void DisplayInfo()
    {
        Console.WriteLine(name);
        Console.WriteLine(company);
        Console.WriteLine(price);
    }
}

