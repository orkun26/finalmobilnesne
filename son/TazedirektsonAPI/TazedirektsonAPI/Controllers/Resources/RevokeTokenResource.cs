using System.ComponentModel.DataAnnotations;

namespace TazedirektsonAPI.Controllers.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}