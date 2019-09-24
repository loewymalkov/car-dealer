using System;
using System.Collections.Generic;


class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  public string Details;


  public Car(string makeModel, int price, int miles, string details)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Details = details;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    if ((Price < maxPrice) && (Miles < maxMiles))
    {
     return true;   
    } 
    else 
    {
     return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "Compact, easy maintenance classic offroader");
    Car yugo = new Car("1980 Yugo Koral", 700, 56000, "Eastern block hatchback city car");
    Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "Large station wagon");
    Car amc = new Car("1976 AMC Pacer", 400, 198000, "Compact 2-door hatchback");

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum mileage: ");
    string stringMaxMileage = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMileage);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice, maxMiles) == true)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }
    if (CarsMatchingSearch.Count == 0)
      {
        Console.WriteLine("Nothing matches your search criteria please don't be so picky");
      }
      else 
      {
        foreach(Car automobile in CarsMatchingSearch)
      {
          Console.WriteLine(automobile.MakeModel + ": " + automobile.Details);
      }
      }
  }
}
