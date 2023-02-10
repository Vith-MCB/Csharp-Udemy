/*
 * INHERITANCE
 * 
 * Inheritance allows us to define a class in terms of another class, which makes it easier to create
 * and maintain an application. It also helps to make code reusable and speeds up the implementation.
 */

/*

o---o                 
| p | passes on       o---o
| a | ----------->    | c | -> can have different 
| r |                 | h |    properties and methods.
| e |                 | i |
| n | <-----------    | l | 
| t |  inherit prop.  | d |
o---o  and meth. from o---o

*/

//In this code example:
//Electrical device: Parent
//TV: child
//Radio: child

using Inheritance;

Radio radio1 = new Radio(true, "panasonic");
Console.WriteLine("Is Radio on? {0}, Radio Brand: {1}", radio1.IsOn, radio1.Brand);

radio1.ListenRadio();
radio1.SwitchOff();
radio1.ListenRadio();

Console.WriteLine("____________________________________________");

TV tv1 = new TV(false, "Sony");
Console.WriteLine("Is TV on? {0}, TV Brand: {1}", tv1.IsOn, tv1.Brand);

tv1.WatchTV();
tv1.SwitchOn();
tv1.WatchTV();