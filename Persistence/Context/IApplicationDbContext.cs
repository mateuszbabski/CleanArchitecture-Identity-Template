using Infrastructure.Identity.Model;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> ApplicationUsers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}