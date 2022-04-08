using RayBrennan.Models;
using System.Threading.Tasks;


namespace RayBrennan.Data
{

    internal interface IRestService
    {
        Task<Price> GetLatestPriceAsync();

    }

}
