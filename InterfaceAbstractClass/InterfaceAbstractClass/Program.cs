using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Container for Widget Classes
using WidgetClasses;


namespace InterfaceAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tests
            SmallWidget testWidget = new SmallWidget();
                        
            testWidget.DisplayComponents();                     




            CustomizableWidget Custom1 = new CustomizableWidget(9, 8, 7);

            Custom1.DisplayComponents();                     

        }
    }
}
