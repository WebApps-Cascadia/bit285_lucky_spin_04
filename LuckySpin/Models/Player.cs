using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player //TODO: Annotate the Player properties as described in section 3.
    {
        [Required (ErrorMessage = "Please provide your name")]
        public string FirstName { get; set; }

        [Range(1,10, ErrorMessage = "Choose a number")]
        public int Luck { get; set; }
    }
}