using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetClasses
{   

    /* By having an abstract class we can can provide all classes that extend this class
    with default, fields, properties, methods and more. By incuding abstract methods we 
    require all classes that inplement this class to provide their own implementation of
    methods which are abstract. Abstract classes can not be instantiated.
    
       This class defines everything that a widget should have.
         */
    public abstract class Widget : IWidget
    {
        private int _numberOfGears = 0;
        private int _numberOfSprings = 0;
        private int _numberOfLevers = 0;

        public int NumberOfGears { get => _numberOfGears; set => _numberOfGears = value;}
        public int NumberOfSprings { get => _numberOfSprings; set => _numberOfSprings = value; }
        public int NumberOfLevers { get => _numberOfLevers; set => _numberOfLevers = value; }

        public void DisplayComponents()
        {
            Console.WriteLine("Number of Gears: " + this._numberOfGears);
            Console.WriteLine("Number of Levers: " + this._numberOfLevers);
            Console.WriteLine("Number of Springs: " + this._numberOfSprings);
        }
        
        /* Abstract method for returning the price of the widget. */
        public abstract decimal Price();

        //Default Constructor for Widgets
        public Widget() { }
            
    }
}
