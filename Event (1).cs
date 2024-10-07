using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Event
    {
        private int id;
        private string title;
        private DateTime start;
        private List<Event> eventList;

        public int Id {
           get { return id; }
           set { id = value; }
        }

      
        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        

        public Event(int id, string title, DateTime start, List<Event> eventList)
        {
            Id = id;
            Title = title;
            Start = start;
            eventList = eventList;
        }
       

        // שליפת כל הארועים 
        public List<Event> getAllEvents()
        {
            return eventList;
        }

        //הוספת ארוע חדש
     public void AddEvent(Event e)
        {
            eventList.Add(e);
        }

        public void updateTitle(int id, string newTitle)
        {
            var a = eventList.Where(n => n.id == id);
            foreach (var n in a)
            {
                n.Title = newTitle;
            }
        }

        public void remove(int id)
        {
            var a = eventList.Where(n => n.id == id);
            foreach (var n in a)
            {
                eventList.Remove(n);
            }
        }


    }
}
