using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetClasses
{

    /* This is an Interface, a contract, that states what methods a class, or struct, must include
      in order to be considered an Interface of a specic type. Interfaces only declare 
      methods, properties, events and indexers. 
      
      By including this interface we are stating what must be included in order to be considered
      a widget and what methods it must have.

      */
    interface IWidget
    {        
        void DisplayComponents();

        decimal Price();
    }
}
