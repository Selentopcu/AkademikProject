using AkademikProjectWeb.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikProjectWeb.Entity.Model;
public class EventImage : BasicEntity, IEntity
{
    public int Rank { get; set; }
    public string? ImageUrl { get; set; }
    public int EventID { get; set; }
    public Event? Event { get; set; }
}
