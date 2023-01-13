using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }

}