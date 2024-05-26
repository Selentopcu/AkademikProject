using AkademikProjectWeb.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikProjectWeb.Entity.Model;
public class UserConfrim : BasicEntity, IEntity
{
    public int UserMemberID {  get; set; }
    public UserMember? UserMember { get; set; }
    public string? ConfrimCode { get; set; }
    public bool ConfirmActive { get; set; }
}
