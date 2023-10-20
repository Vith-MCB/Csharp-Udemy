using Employees_Bosses_and_Trainees;

Console.WriteLine("---------Employee object---------");

Employee employee1 = new Employee("Tulio Seilaoque", 2400.0);

Console.WriteLine("{0}, first name: {1}",employee1.Name,employee1.FirstName);

employee1.Work();
employee1.Pause();

Console.WriteLine("--------- Trainee object---------");

Trainee trainee1 = new Trainee("Vitor Ribeiro", 1240.0, 6, 4);

trainee1.Work();
trainee1.Pause();
trainee1.Learn();

Console.WriteLine("---------- Boss object ----------");

Boss boss1 = new Boss("Adilson Baptista", 4000.0, 8, true);

boss1.Work();
boss1.Pause();
boss1.Lead();
boss1.GoHome();