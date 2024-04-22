using System.ComponentModel.DataAnnotations;

namespace OtoServis.WebUI.Models
{
    public class CustomerLoginViewModel
    {
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bıralılamaz!")]
        public string Email { get; set; }
        [Display(Name = "Şifre"), StringLength(50), Required(ErrorMessage = "{0} Boş Bıralılamaz!")]
        public string Sifre { get; set; }
    }
}
