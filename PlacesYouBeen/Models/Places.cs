using System;
using System.Collections.Generic;

namespace PlacesWB.Models
{
    public class Places
    {
      private static List<Places> _list = new List<Places>(){};
      public string cityName { get; set;}
      public string Description { get; set; }
      public string TimeStamp { get; set; }
      public int Id {get; set; }


      //Constructor
      public Places(string cityname, string description, string timestamp)
      {
        cityName = cityname;
        Description = description;
        TimeStamp = timestamp;
        _list.Add(this);
        Id = _list.Count;
      }

      //Return List of Places
      public static List<Places> GetAll()
      {
        return _list;
      }

      public static void ClearAll()
      {
        _list.Clear();
        return;
      }

      public static Places Find(int searchId)
      {
        return _list[searchId-1];
      }
    }
}