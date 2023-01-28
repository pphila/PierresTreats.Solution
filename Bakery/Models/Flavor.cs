using System.Collections.Generic;
// using System.ComponentModel.DataAnnotation;

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Type { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}