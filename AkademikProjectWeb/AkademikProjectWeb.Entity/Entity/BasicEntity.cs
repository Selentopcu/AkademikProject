using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademikProjectWeb.Entity.Entity;
public class BasicEntity
{

    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public bool IsActive { get; set; }
}
