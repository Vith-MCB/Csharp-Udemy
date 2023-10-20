using System;

namespace Coding.Exercise
{
    
    public interface IShootable{
        void Shoot();
    }
    
    public class Weapon
    {
        public static string Name {get;set;}
        public Weapon(){ }
        public void Label(){
            Console.WriteLine("This is {0}!", Name);
        }
    }
    public class Gun : Weapon, IShootable
    {
        public Gun()
        {
            Gun.Name = "Gun";
        }
        public void Shoot(){
            Console.WriteLine("Bang!");
        }
    }
    
    public static class Program{
        static public void Main(string[] args){
            // new instance 
            Gun pist = new Gun();

            // test for methods
            pist.Label();
            pist.Shoot();

            // verifying the interface and the parent class
            if (pist is IShootable && pist is Weapon)
                System.Console.WriteLine("Yes, it is my parents.");
        } 
    }
}