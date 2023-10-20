using InterfaceDemo2;

//Creating new objects of type Chair
Chair officeChair = new Chair("Brown", "Leather");
Chair gamingChair = new Chair("Black", "Plastic");

//Creating a new object of type car
Car damagedCar = new Car(120f,"Red");

/* Calling Destroy method of each object
 
Console.WriteLine("DESTROYING OFFICE CHAIR");
officeChair.Destroy();

Console.WriteLine("\nDESTROYING GAME CHAIR");
gamingChair.Destroy();
*/

//Using car "DestroyablesNearby" to destroy IDestroyable objects
damagedCar.DestroyablesNearby.Add(officeChair);
damagedCar.DestroyablesNearby.Add(gamingChair);

Console.WriteLine("\nDESTROYING CAR");
damagedCar.Destroy();