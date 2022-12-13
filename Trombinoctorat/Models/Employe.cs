using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace Trombinoctorat.Models
{
    public class Employe
    {
        public Employe()
        {
        }

        [Key]
        public int EmployeId { get; set; }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }

      /*  public int PosteId { get; set; }
        public string BureauCode { get; set; }

        public virtual Poste Poste { get; set; }
        public virtual Bureau Bureau { get; set; }
    */



    }
}
