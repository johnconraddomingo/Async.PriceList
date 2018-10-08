using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async.ThirdParty
{
    public interface IPriceListSource
    {
        Task<List<string>> GetPricesAsync();

    }

    public class PriceListSource : IPriceListSource
    {
        public Task<List<string>> GetPricesAsync()
        {
            /*
               using (StreamReader reader = new StreamReader(file))
        {
            string v = await reader.ReadToEndAsync();

            // ... Process the file data somehow.
            count += v.Length;

            // ... A slow-running computation.
            //     Dummy code.
            for (int i = 0; i < 10000; i++)
            {
                int x = v.GetHashCode();
                if (x == 0)
                {
                    count--;
                }
            }
        }
        */
            throw new NotImplementedException();
        }
    }
}
