namespace ASP.NET_Core.MvcWebApp.Services
{
    public class MailKitServiceOptions
    {
        public const string MailKitService = "MailKitService";
        public string MailDriver { get; set; }
        public string MailServer { get; set; }
        public int MailPort { get; set; }
        public string MailName { get; set; }
        public string MailUserName { get; set; }
        public string MailPassword { get; set; }
    }
}
