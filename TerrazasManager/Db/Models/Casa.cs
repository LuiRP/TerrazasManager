using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerrazasManager.Db.Models
{
    [Table("casa")]
    public class Casa
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        [Required]
        public string NumeroCasa { get; set; }
        public bool EsResidencia { get; set; }
        [Required]
        public int PersonasFamilia { get; set; }
        [Required]
        public string JefeFamilia { get; set; }
    }
}
