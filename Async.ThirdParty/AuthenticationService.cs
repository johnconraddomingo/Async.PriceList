using System;
using System.Threading.Tasks;

namespace Async.ThirdParty
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(string username, string password, int delayInMs);
    }

    public class AuthenticationService : IAuthenticationService
    {
        public async Task<bool> AuthenticateAsync(string username, string password, int delayInMs)
        {
            // This is taking a long time!
            await Task.Delay(5000);
            return username.StartsWith("j");
        }
    }
}
