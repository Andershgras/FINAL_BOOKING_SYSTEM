using System.ComponentModel.DataAnnotations;

namespace FINALBOOKINGSYSTEM.Models
{
    public class Item


    {
        [Required(ErrorMessage = "ID is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "ID must be greater than 0.")]
        public int? Id { get; set; }  // Nullable to allow custom error messages

        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Item Name")]  // Custom label for UI
        public string Name { get; set; }

        [Required(ErrorMessage = "Booking status is required.")]
        [Display(Name = "Is Booked?")]
        public bool? IsBooked { get; set; }  // Nullable to allow validation
    


    
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBooked { get; set; }

        public Item(int id, string name, bool isBooked)
        {
            this.Id = id;
            this.Name = name;
            this.IsBooked = isBooked;
        }
        public Item()
        {
            this.Id = 0;
            this.Name = "Lokale0";
            this.IsBooked = false;
        }
    }
}
