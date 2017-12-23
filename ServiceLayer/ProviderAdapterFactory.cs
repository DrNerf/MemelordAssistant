using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ProviderAdapterFactory
    {
        public static IEnumerable<IProviderAdapter> GetAllProviderAdapters()
        {
            return new IProviderAdapter[]
            {
                new GiphyProviderAdapter()
            };
        }
    }
}
