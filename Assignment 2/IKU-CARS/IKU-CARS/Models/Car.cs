using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IKU_CARS.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Maker is required")]
        [StringLength(50, ErrorMessage = "Maker cannot exceed 50 characters")]
        [Display(Name = "Maker")]
        public string Maker { get; set; }

        [Required(ErrorMessage = "Model is required")]
        [StringLength(50, ErrorMessage = "Model cannot exceed 50 characters")]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1900, 2030, ErrorMessage = "Year must be between 1900 and 2030")]
        [Display(Name = "Year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Car Type is required")]
        [StringLength(20, ErrorMessage = "Car Type cannot exceed 20 characters")]
        [Display(Name = "CType")]
        public string CType { get; set; }

        [StringLength(100, ErrorMessage = "Image filename cannot exceed 100 characters")]
        [Display(Name = "CImage")]
        public string CImage { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 999999.99, ErrorMessage = "Price must be greater than 0")]
        [Display(Name = "Fiyat")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "CAvailable")]
        public bool CAvailable { get; set; }
    }
}
