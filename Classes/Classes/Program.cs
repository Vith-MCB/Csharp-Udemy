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