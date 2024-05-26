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
    // Key = Birincil anahtar olduğunu belirliyoruz.
    // Identity=1 den başlayıp 1 er 1 er artmasını sağlıyor
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public bool IsActive { get; set; }
}
