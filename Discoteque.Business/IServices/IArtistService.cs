using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public interface IArtistService
{
    Task<IEnumerable<Artist>> GetArtistsAsync();
    Task<Artist> GetByIde(int id);
    Task<Artist> CreateArtistAsync(Artist artist);
    Task<Artist> UpdateArtist(Artist artist);
}