using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace ListaStudenti.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Te rog introdu numele!")]
        public string Nume { get; set; }

        [Required(ErrorMessage = "Te rog introdu anul de studiu de la 1 pana la 3")]
        [Range(1, 3, ErrorMessage = "Anul de studiu trebuie sa fie cuprins intre 1 si 3")]
        public int? AnStudiu { get; set; }

        [Required(ErrorMessage = "Te rog introdu nota de absolvire")]
        [Range(5,10, ErrorMessage ="Nota de stiudiu trebuie sa fie cuprinsa intre 5 si 10") ]
        public int? Nota { get; set; }

  
    }
}
