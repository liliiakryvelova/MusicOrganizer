using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public Image image { get; set; }
    public int Id { get; }
    private static List<Place> _instances = new List<Place> { };

    public Place(string cityname, Image image)
    {
      CityName = cityname;
      this.image = image;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
