using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IProviderAdapter
    {
        Task<IEnumerable<ResultItemModel>> GetItems(int page);
    }
}
