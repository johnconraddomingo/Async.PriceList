using System;
using System.Threading.Tasks;

namespace Async.ThirdParty
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string username, string password);
    }

    public class AuthenticationService : IAuthenticationService
    {
        public async Task<bool> Authenticate(string username, string password)
        {
            // This is taking a long time!
            await Task.Delay(5000).ConfigureAwait(false);

            return username.StartsWith("j");
        }
    }
}
