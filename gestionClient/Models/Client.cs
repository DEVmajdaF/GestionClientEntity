using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gestionClient.Models
{
    public class Client
    {

        public int Id { get; set; }
        //Change The Name of the culumn of the table (view )
        [Display(Name="Full Name")]
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Adress { get; set; }
        //Change The Datatype from datetime2 to date of the culumn of the table (view )
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="The Data Must Be a Number")]
        public DateTime Date { get; set; }

    }
}
