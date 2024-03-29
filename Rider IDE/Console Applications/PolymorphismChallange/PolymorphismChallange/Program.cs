﻿/* POLYMORPHISM CHALLENGE.
 *
 * Create a base class Car with two properties HP and Color.
 * Create a constructor setting those two properties.
 * Create a Method called ShowDetails() which shows the HP and color of the car on the Console.
 * Create a Repair Method which writes "Car was repaired!" onto the console.
 * 
 * Create two deriving classes, BMW and Audi, which have their constructor and have an additional property
 * called Model. Also a private member called brand. Brand should be different in each of the two classes.
 *
 * Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.
 * 
 */

using PolymorphismChallange;

class Program
{
    static void Main(string[] args)
    {
        BMW carbmw = new BMW(67, "black", "Z3");
        carbmw.ShowDetails();
        carbmw.Repair();

        Audi carAudi = new Audi(37, "white", "A8");
        carAudi.ShowDetails();
        carAudi.Repair();
        //Using relationship in a inherited class
        carAudi.SetCarIDInfo(12,"Vitor");
        carAudi.GetIDInfo();

        var cars = new List<Car>
        {
            new Audi(200, "blue", "A4"),
            new BMW(300, "pink", "M3")
        };

        foreach (var car in cars)
        {
            car.Repair();
        }
    }
}


