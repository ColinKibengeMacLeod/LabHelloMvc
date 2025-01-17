using System.ComponentModel.DataAnnotations;

namespace LabHelloMvc.Models
{
    public class Person
    {
        [Display(Name = "Person ID: ")]
        public int PersonId { get; set; }

        [Display(Name = "First Name: ")]
        public string FirstName { get; set; } = string.Empty;

        [Display(Name = "Last Name: ")]
        public string LastName { get; set; } = string.Empty;
    }
}
