using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Author { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Landmark { get; set; }
    public string Description { get; set; }
    public int Rating { get; set; }


    public static List<Review> GetReviews()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result); //The API call results in a JSON array
      List<Review> reviewList = JsonConvert.DeserializeObject<List<Review>>(jsonResponse.ToString());

      return reviewList;
    }
    
  }
}    