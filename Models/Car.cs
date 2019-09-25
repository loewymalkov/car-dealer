
using System;

namespace Dealership
{
  class Car
    {
      private string _makeModel;
      private int _price;
      private int _miles;
      private string _details;

      public Car(string makeModel, int price, int miles, string details)
      {
        _makeModel = makeModel;
        _price = price;
        _miles = miles;
        _details = details;
      }

      public string GetMakeModel()
      {
        return _makeModel;
      }
      public int GetPrice()
      {
        return _price;
      }
      public int GetMiles()
      {
        return _miles;
      }
      public string GetDetails()
      {
        return _details;
      }
      public bool WorthBuying(int maxPrice, int maxMiles)
      {
        if ((_price < maxPrice) && (_miles < maxMiles))
        {
        return true;   
        } 
        else 
        {
        return false;
        }
      }
    }
}