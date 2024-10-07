using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Event> list = new List<Event>();

            
            Event firstEvent = new Event(1, "Meeting", DateTime.Now, list);
            firstEvent.AddEvent(new Event(2, "Workshop", DateTime.Now.AddHours(2), list));
            firstEvent.AddEvent(new Event(3, "shopping", DateTime.Now.AddHours(5), list));

        }
    }
}
