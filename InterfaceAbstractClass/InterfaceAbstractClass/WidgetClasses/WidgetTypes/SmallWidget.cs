using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetClasses
{

    /* Because a Small Widget has a   */
    public class SmallWidget : Widget
    {        

        public SmallWidget()
        {
            this.NumberOfGears = 2;
            this.NumberOfLevers = 1;
            this.NumberOfSprings = 3;
        }

        public override decimal Price()
        {
            return 100m;
        }
    }
}
