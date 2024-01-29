using System.ComponentModel.DataAnnotations;
namespace CookApp.Models
{
    public class Recipe
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nazwa dania jest wymagana.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Składniki są wymagane.")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Kroki są wymagane.")]
        public string Steps { get; set; }

    }

}
