using System.ComponentModel;
using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{
    Random rnd = new Random();
    public static List<Artist> list = new List<Artist>();
    public async Task<Artist> CreateArtistAsync(Artist artist)
    {
        int number = rnd.Next();
        artist.Id = number;
        list.Add(artist);
        return artist;
        // throw new NotImplementedException();
    }
    
    public async Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        // throw new NotImplementedException();
        return list;
    }

    public Task<Artist> GetByIde(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }

    
}
