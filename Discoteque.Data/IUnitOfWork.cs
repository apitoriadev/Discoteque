using Discoteque.Data.Models;
using Discoteque.Data.IRepositories;

namespace Discoteque.Data;

public interface IUnitOfWork
{
    IRepository<int, Artist> ArtistRepository{get;}
    Task SaveAsync();
}