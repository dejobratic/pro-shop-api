namespace ProShop.Auth.App.Models
{
    public interface IJWTSettings
    {
        public string Secret { get; set; }

        public byte[] GetSecretAsBytes();
    }
}
