using AkademikProjectWeb.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikProjectWeb.Entity.Model;
public class Event : BasicEntity, IEntity
{
    public Event()
    {
        EventImages = new HashSet<EventImage>();
    }
    public string? EventName { get; set; }
    public string? EventDescription { get; set; }
    public int EventSubjectID { get; set; }
    public EventSubject? EventSubject { get; set; }
    public int CityID { get; set; }
    public City? City { get; set; }
    public DateTime EventDate { get; set; } // Geçmiş Eventleri takip etmek için
    public ICollection<EventImage>? EventImages { get; set; }
}
