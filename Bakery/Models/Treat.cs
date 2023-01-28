using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Field Cannot Be Empty!")]
    public string Name { get; set; }
    public string Description { get; set; }
    [Range(1, int.MaxValue)]
    public int Quantity { get; set; }
    public List<TreatFlavor> JoinEntities { get; set; }
  }
}