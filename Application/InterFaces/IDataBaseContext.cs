using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Application.InterFaces
{
    public interface IDataBaseContext
    {
        DbSet<User> Users { get; set; }
        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
