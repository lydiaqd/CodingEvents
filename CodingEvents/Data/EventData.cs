using System;
using CodingEvents.Models;

namespace CodingEvents.Data
{
	public class EventData
	{
		static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

		//Fetch all the events
		public static IEnumerable<Event> GetAll()
		{
			return Events.Values;
		}

		//Add a new event to dictionary
		public static void Add(Event newEvent)
		{
			Events.Add(newEvent.Id, newEvent);
		}

		//Remove an event
		public static void Remove(int id)
		{
			Events.Remove(id);
		}

		//Fetch an event
		public static Event GetById(int id)
		{ 
			return Events[id];
		}
	} 
}

