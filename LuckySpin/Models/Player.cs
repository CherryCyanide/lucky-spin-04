using System.ComponentModel.DataAnnotations;
namespace LuckySpin.Models
{
    public class Player 
    {
        //TODO: Annotate both Player properties as shown in the exercise Figure 1 and the resources section.
        [Required(ErrorMessage = "First Name Is required")]
        public string FirstName { get; set; } = "Player";

        [Required(ErrorMessage = "Lucky Number is required")]
        [Range(1,9, ErrorMessage = "Lucky Number is required")]
        public int Luck { get; set; }
    }
}