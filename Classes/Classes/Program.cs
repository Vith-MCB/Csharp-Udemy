/*
//Crating object of my class

using Classes;

//Instance of Human Class
Human person1 = new Human("Vitor", "Ribeiro", 20); //Using parameterized constructor


//The variables below doesn't need to be used anymore, becouse of the constructor of the Human Class
//person.firstName = "Vitor";
//person.lastName = "Ribeiro";

person1.IntroduceMyself();


Human person2 = new Human("Luiz", "Henrique", 17); //Using parameterized constructor
person2.IntroduceMyself();

Human basicHuman = new Human(); //Using basic constructor
basicHuman.IntroduceMyself();
*/

using Classes;
using MembersC;

Box box = new Box(20,30,10);

Console.WriteLine("Box Height is: {0}", box.Height);

Console.WriteLine("Box Width is: {0}", box.Width);

Console.WriteLine("Box length is: {0}", box.GetLength());

Console.WriteLine("Box volume is: {0}", box.Volume);

Console.WriteLine("Box Front Surface is: {0}", box.FrontSurface);

Members member = new Members("Vitor", "Programmer", 20,2000);

member.IntroduceYourself(false);