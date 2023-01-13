using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Store.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}