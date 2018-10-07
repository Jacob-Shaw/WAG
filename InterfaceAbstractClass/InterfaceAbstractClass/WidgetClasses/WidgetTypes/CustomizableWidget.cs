using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetClasses
{
    public class CustomizableWidget : Widget
    {
        public CustomizableWidget(int gears, int levers, int springs)
        {
            this.NumberOfGears = gears;
            this.NumberOfLevers = levers;
            this.NumberOfSprings = springs;
        }

        //  Work out the exact price later !!!!!!!!!!!!!!!!!!!!!!!!
        public override decimal Price()
        {
            return 100m;
        }
    }
} 
