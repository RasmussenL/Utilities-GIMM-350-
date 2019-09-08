//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            Console.WriteLine("Hello, world!");
            
            int meaningOfLife = 42;
            float smallPi = 3.14f;
            double bigPi = 3.14159265359;
            string vaporWare = "Half Life 3";
            const bool likesPizza = false;
            //const makes the variable immutable
            
            string[] writers = { "Anthony", "Brian", "Eric", "Sean" };
            string[] editors = new string[5]; //we don't know the editors yet
            Console.WriteLine(writers[2]);
            
            if (likesPizza == false)
            {
                Console.WriteLine("You monster!");
                //barf noises
            }
            
            bool isMonster = (likesPizza == true) ? false : true;
            
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("C# Rocks!");
            }
            
            foreach (string writer in writers)
            {
                Console.WriteLine(writer);
            }
            
            if (meaningOfLife == 42)
            {
                bool inScope = true;
                //inScope only exists within the scope of this if statement
            }
            
            Point2D myPoint = new Point2D();
            myPoint.X = 10;
            myPoint.Y = 20;
            
            Point2D anotherPoint = new Point2D();
            anotherPoint.X = 5;
            anotherPoint.Y = 15;
            
            myPoint.AddPoint(anotherPoint);
                
            Console.WriteLine(myPoint.X);
            Console.WriteLine(myPoint.Y);
            
            Point2D yetAnotherPoint = myPoint;
            yetAnotherPoint.X = 100;
            //replicated myPoint, but changed the x value
            Console.WriteLine(myPoint.X);
            Console.WriteLine(yetAnotherPoint.X);
            
            Point2DRef pointRef = new Point2DRef();
            pointRef.X = 20;
            Point2DRef anotherRef = pointRef;
            anotherRef.X = 25;
            
            Console.WriteLine(pointRef.X);
            Console.WriteLine(anotherRef.X);
            //now the points return as the same
            
            pointRef = null;
            
            anotherRef.X = 125;
            Console.WriteLine(anotherRef.X);
            //outputs 125
            
            RenFairePerson person = new RenFairePerson();
            person.Name = "Igor the Ratcatcher";
            person.SayHello();
        }
    }
    
    //a structre is like a class but not
    /*Ultimately, your structures are meant to handle short-lived objects that represent a
value, such as a point in 3D space. A class is meant to exist for larger stretches of your
program and tend to be unique, such as a player character.*/
    
    struct Point2D
    {
        public int X;
        public int Y;
        
        public void AddPoint(Point2D anotherPoint)
        {
            this.X = this.X + anotherPoint.X;
            this.Y = this.Y + anotherPoint.Y;
        }
    }
    
    class Point2DRef
    {
        public int X;
        public int Y;
        
        public void AddPoint(Point2DRef anotherPoint)
        {
            this.X = this.X + anotherPoint.X;
            this.Y = this.Y + anotherPoint.Y;
        }
    }
    
    class Person
    {
        public string Name;
        public virtual void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    
    //inheritance
    class RenFairePerson : Person
    {
        public override void SayHello()
            {
                base.SayHello();
                Console.Write("Huzzah!");
            }
    }
}