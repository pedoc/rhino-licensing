namespace Rhino.Licensing
{
    /// <summary>
    /// Service contract of subscription server.
    /// </summary>
    public interface ISubscriptionLicensingService
    {
        /// <summary>
        /// Issues a leased license
        /// </summary>
        /// <param name="previousLicense"></param>
        /// <returns></returns>
        string LeaseLicense(string previousLicense);
    }
}