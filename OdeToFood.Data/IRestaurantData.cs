using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
  public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData: IRestaurantData
    {
        List<Restaurant> restaurants; 

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Abner's Pizza", Location = "Curitiba", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Pedro's Taco", Location = "Sao Paulo", Cuisine = CuisineType.Mexican },
                new Restaurant { Id = 3, Name = "Marcia's Cuisine", Location = "Brasilia", Cuisine = CuisineType.None }
            };
        }

    public IEnumerable<Restaurant> GetAll() => from r in restaurants
                                               orderby r.Name
                                               select r;
  }
}
