using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrazasManager.Db.Models
{
    [Table("operativo")]
    public class Operativo
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del operativo es requerido")]
        public string NombreOperativo { get; set; }
        [Required(ErrorMessage = "La fecha del operativo es requerida")]
        public DateTime FechaOperativo { get; set; }
        //No estoy seguro si este campo es el correcto
        public string AgregarFamilias { get; set; }
        public string DescripcionOperativo { get; set; }

    }
}

