using System.Collections.Generic;
// using System.ComponentModel.DataAnnotation;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Desciption { get; set; }
    public int Quantity { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}