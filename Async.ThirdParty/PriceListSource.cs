using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Async.ThirdParty
{
    public interface IPriceListSource
    {
        Task<List<string>> GetPricesAsync(); 
    }

    public class PriceListSource : IPriceListSource
    {
        public async Task<List<string>> GetPricesAsync()
        {
            var pricelistReturn = new List<string>();

            var file = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Pricelist.txt");
            using (var reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();

                // A slow-running dummy code 
                var count = v.Length;
                for (int i = 0; i < 1000; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                    await Task.Delay(10);
                }

                // Was that long enough? 
                return v.Split('\n').ToList();
            }
            // Want to show progress?
            // https://blogs.msdn.microsoft.com/dotnet/2012/06/06/async-in-4-5-enabling-progress-and-cancellation-in-async-apis/
        }
    }
}
