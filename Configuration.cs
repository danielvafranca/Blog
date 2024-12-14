namespace Blog;

public static class Configuration
{
    //Token - O token que vamos utilizar está no formato json
    public static string JwtKey { get; set; } = "8443783fa8f54c3fa6f6a7c19e1448ea";
    public static string ApiKeyName = "api_key";
    public static string ApiKey = "curso_api_IlTevUM/z0ey3NwCV/unWg==";
    public static SmtpConfiguration Smtp = new();


    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
