using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CretaceousClient.Models
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
    
  }
}    