namespace Rhino.Licensing
{
    public class SubscriptionLicensingServiceClient:LicenseClientBase, ISubscriptionLicensingServiceClient
    {
        public SubscriptionLicensingServiceClient(LicenseClientOptions options) : base(options)
        {
        }

        public string LeaseLicense(string previousLicense)
        {
            return Post("/api/SubscriptionLicensing/LeaseLicense", new {previousLicense});
        }
    }
}
