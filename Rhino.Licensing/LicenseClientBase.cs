using System.Net;
using FluentAssertions;
using RestSharp;

namespace Rhino.Licensing
{
    /// <summary>
    /// LicenseClientBase
    /// </summary>
    public abstract class LicenseClientBase
    {
        protected readonly RestClient RestClient;
        protected readonly LicenseClientOptions Options;

        protected LicenseClientBase(LicenseClientOptions options)
        {
            options.Should().NotBeNull();
            options.LicenseServerUri.Should().NotBeNullOrEmpty();
            Options = options;
            RestClient = new RestClient(Options.LicenseServerUri);
        }

        protected string Post(string resource, object jsonBody)
        {
            var req = new RestRequest(resource, Method.POST);
            req.AddJsonBody(jsonBody);
            var resp = RestClient.Execute(req);
            return resp.Content;
        }

        protected T Post<T>(string resource, object jsonBody)
        {
            var req = new RestRequest(resource, Method.POST);
            req.AddJsonBody(jsonBody);
            var resp = RestClient.Execute<T>(req);
            if (resp.StatusCode != HttpStatusCode.OK) return default;
            if (resp.Data == null) return default;
            return resp.Data;
        }

        protected T Get<T>(string resource, params Parameter[] parameters)
        {
            var req = new RestRequest(resource, Method.GET);
            if (parameters != null) foreach (var parameter in parameters) req.AddOrUpdateParameter(parameter);
            var resp = RestClient.Execute<T>(req);
            return resp.Data;
        }
    }
}
