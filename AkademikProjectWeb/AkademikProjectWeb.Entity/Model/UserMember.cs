using AkademikProjectWeb.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikProjectWeb.Entity.Model;
public class UserMember : BasicEntity, IEntity
{
    public UserMember()
    {
        UserConfrims = new HashSet<UserConfrim>();    
    }
    public string? NameSurname { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public ICollection<UserConfrim> UserConfrims { get; set; }
}
