using System.ComponentModel.DataAnnotations;

namespace FormApplicationApiDotNet.Model
{
    public class Person
    {
        [Required,]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public string Company { get; set; }
        public string ReasonForContact { get; set; }
        public string MoreDetails { get; set; }

    }
}
