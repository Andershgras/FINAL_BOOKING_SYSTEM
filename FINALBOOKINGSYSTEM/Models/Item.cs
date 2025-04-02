using System.ComponentModel.DataAnnotations;

namespace FINALBOOKINGSYSTEM.Models
{
    public class Item
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "Id is required")]
        //[Range(typeof(int), "1", "100", ErrorMessage = "Id skal være mellem {0} og {100}")]
        public int? Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name skal være mellem {2} og {1} tegn")]
        public string Name { get; set; }

        //[Display(Name = "IsBooked")]
        //[Required(ErrorMessage = "Lokale is booked")]
        //[Range(typeof(bool), "false", "true", ErrorMessage = "Lokale is booked")]
        //public bool IsBooked { get; set; }

        public Item(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            //this.IsBooked = isBooked;
        }
        public Item()
        {
            this.Id = 0;
            this.Name = "Lokale0";
            //this.IsBooked = false;
        }
    }
}
