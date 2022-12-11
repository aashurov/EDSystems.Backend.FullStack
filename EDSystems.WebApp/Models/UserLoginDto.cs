using System.ComponentModel.DataAnnotations;

namespace EDSystems.WebApp.Models
{
    /// <summary>
    ///
    /// </summary>
    public class UserLoginDto
    {
        /// <summary>
        ///
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}