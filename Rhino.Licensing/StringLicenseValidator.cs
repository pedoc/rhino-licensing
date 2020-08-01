namespace Rhino.Licensing
{
    /// <summary>
    /// Validates content of a license file
    /// </summary>
    public class StringLicenseValidator : AbstractLicenseValidator
    {
        /// <summary>
        /// Creates a new instance of <seealso cref="StringLicenseValidator"/>
        /// </summary>
        /// <param name="serviceFactory"></param>
        /// <param name="publicKey">public key</param>
        /// <param name="license">license content</param>
        public StringLicenseValidator(ServiceFactory serviceFactory, string publicKey, string license)
            : base(serviceFactory,publicKey)
        {
            License = license;
        }

        /// <summary>
        /// License content
        /// </summary>
        protected override string License
        {
            get; set;
        }
    }
}