using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cSharpApi.Models
{
    [Table("xamarinKorisnici")]
    public class XamarinKorisnik
    {
        [Key]
        public long IdUser {get; set;}
        public string userName {get; set;}
    }
}