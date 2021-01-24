using System.Text;

namespace ProShop.Auth.App.Models
{
    public class JWTSettings :
        IJWTSettings
    {
        public string Secret { get; set; }

        public byte[] GetSecretAsBytes() 
            => Encoding.ASCII.GetBytes(Secret);
    }
}
