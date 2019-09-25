
namespace Models
{
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
}