using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ChallengeTecnico_Ears.Models
{
    public class OfficeModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string CompanyName { get; set; } = string.Empty;

        public int CUIT { get; set; } = 0;

        public long IdPerson { get; set; } = 0;

        public bool Active { get; set; } = true;

        [JsonIgnore]
        public virtual PersonModel Person { get; set; }
    }
}
