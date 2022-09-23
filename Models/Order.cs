using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace BethanysPieShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }

        [Required(ErrorMessage ="Please enter your first name")]
        [Display(Name = "First name")]
        [StringLength(30)]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last name")]
        [StringLength(30)]
        public string LastName { get; set; } = string.Empty;
        [Required (ErrorMessage ="Please enter your address")]
        [Display(Name ="Address line 1")]
        [StringLength (50)]
        public string AddressLine1 { get; set; } = string.Empty;
        [Display(Name ="Address line 2")]
        public string? AddressLine2 { get; set; }
        [Required(ErrorMessage ="Please enter your zipcode")]
        [Display(Name ="Zip code")]
        [StringLength (10, MinimumLength =5)]
        public string ZipCode { get; set; } = string.Empty;
        [Required(ErrorMessage ="Please enter your city")]
        [StringLength (50)]
        public string City { get; set; } = string.Empty;
        [StringLength (50)]
        public string Country { get; set; } = string.Empty;
        [Required]
        [StringLength (50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;
        [BindNever]
        public decimal OrderTotal { get; set; }
        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
