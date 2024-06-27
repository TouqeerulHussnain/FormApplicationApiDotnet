using System.ComponentModel.DataAnnotations;

namespace FormApplicationApiDotNet.Model
{
    public class PersonDto
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public string Company { get; set; }
        public string ReasonForContact { get; set; }
        public string MoreDetails { get; set; }
    }
}
