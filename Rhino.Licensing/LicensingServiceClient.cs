using System;

namespace Rhino.Licensing
{
    public class LicensingServiceClient:LicenseClientBase, ILicensingServiceClient
    {
        public LicensingServiceClient(LicenseClientOptions options) : base(options)
        {
        }

        public string LeaseLicense(string machine, string user, Guid id)
        {
            return Post("/api/LicensingService/LeaseLicense", new {machine, user, id});
        }
    }
}
