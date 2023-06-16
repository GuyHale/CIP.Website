using CIP.Website.Models;

namespace CIP.Website.Interfaces
{
    public interface ICryptocurrency
    {
        Task<IEnumerable<Cryptocurrency>> Get();
    }
}
