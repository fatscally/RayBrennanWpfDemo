using NoFrixionWpf.Models;
using System.Threading.Tasks;


namespace NoFrixionWpf.Data
{

    internal interface IRestService
    {
        Task<Price> GetLatestPriceAsync();

    }

}
