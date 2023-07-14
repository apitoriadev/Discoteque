using System.Collections;
using System;
using Discoteque.Data.Models;

namespace Discoteque.Business.IServices
{
    public interface IArtistsService
    {
        Task<IEnumerable<Artist>> GetArtistsAsync();
        Task<Artist> GetById(int id);
        Task<Artist> CreateArtist(Artist artist);
        Task<Artist> UpdateArtist(Artist artist);
        Task AddAsync(Artist artist);
        Task<IEnumerable<Artist>> GetById(long id);
        Task UpdateAsync(Artist artist);
    }
}