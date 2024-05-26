using AkademikProjectWeb.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikProjectWeb.Entity.Model;
public class City : BasicEntity,IEntity
{
    public City()
    {
        Events=new HashSet<Event>();
    }
    public string? CityName { get; set; }
    public string? CityCode { get; set; }
    public ICollection<Event>? Events { get; set; }
}
