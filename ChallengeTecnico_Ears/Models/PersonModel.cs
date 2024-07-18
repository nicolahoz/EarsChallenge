using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChallengeTecnico_Ears.Models
{
    public class PersonModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public int Dni { get; set; } = 0;

        public int EmployeeFile { get; set; } = 0;

        public bool Active { get; set; } = true;

        public virtual ICollection<OfficeModel> Offices { get; set; }

    }
}
