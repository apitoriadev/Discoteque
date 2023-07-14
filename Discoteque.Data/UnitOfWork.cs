using Microsoft.EntityFrameworkCore;
using Discoteque.Data.Models;
using Discoteque.Data.IRepositories;
using Discoteque.Data.Repository;

namespace Discoteque.Data;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly DiscotequeContext _context;
    private bool _disposed = false;
    private IRepository<int, Artist> _artistRepository;

    public UnitOfWork(DiscotequeContext context)
    {
        _context = context;
    }

    public IRepository<int, Artist> ArtistRepository
    {
        get 
        {
            if (_artistRepository is null)
            {
                _artistRepository = new Repository<int, Artist>(_context);
            }
            return _artistRepository;
        }
    }

    public async Task SaveAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();
        }
    }
    #region IDisposable
        protected virtual void Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    _context.DisposeAsync();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    
}