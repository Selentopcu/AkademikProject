using AkademikProjectWeb.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikProjectWeb.Entity.Model;
public class EventSubject : BasicEntity, IEntity
{
    public EventSubject()
    {
        Events = new HashSet<Event>();
    }
    //Rank alanı sıralama yapmak için eklenmiştir.
    public int Rank { get; set; }
    public string? SubjectName { get; set; }
    public string? SubjectDescription { get; set; }
    public ICollection<Event>? Events { get; set; }
}
