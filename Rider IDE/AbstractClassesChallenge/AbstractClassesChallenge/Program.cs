using AbstractClassesChallenge;

/*
 * Declaring objects with classes


// Abstract classes can't be instantiated.
// Shape shape1 = ... IS NOT VALID

//Cube  Class inherit from Shape and has its own functions
Console.WriteLine("CUBE:");
Cube cube1 = new Cube(3);
Console.WriteLine("{0} volume is {1}.", cube1.Name,cube1.Volume());


//Creating a Sphere object
Console.WriteLine("\nSPHERE:");
Sphere sphere1 = new Sphere(2);
Console.WriteLine("{0} volume is {1}.", sphere1.Name,sphere1.Volume().ToString("F"));

 */
 
 Shape[] shapesVector = {new Sphere(4), new Cube(3)};

 foreach (Shape shapeObj in shapesVector)
 {
  Console.WriteLine(shapeObj.GetType());
  
  Console.WriteLine("{0} volume is {1}.", shapeObj.Name,shapeObj.Volume().ToString("F"));

  if (shapeObj is Cube)
  {
   Console.WriteLine("This is a cube!\n");
  } else if (shapeObj is Sphere)
  {
   Console.WriteLine("This is a sphere!\n");
  }
  
  /*
   Cube iceCube = shapeObj as Cube;
   if (iceCube == null)
   {
    Console.WriteLine("This shape is no cube!");
   }
  */
 }