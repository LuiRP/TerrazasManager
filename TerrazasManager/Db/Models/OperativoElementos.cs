using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrazasManager.Db.Models
{
    [Table("OperativoElementos")]
    public class OperativoElementos
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        [Required]
        public int OperativoId { get; set; }

        [Required]
        public int CasaId { get; set; }
        
        public string Elementos { get; set; }

    }
}

