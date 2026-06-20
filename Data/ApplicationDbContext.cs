using Microsoft.EntityFrameworkCore;
using _2526_2221050694_BaiThi.Models;

namespace _2526_2221050694_BaiThi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<TinhThanh> TinhThanhs { get; set; } = null!;
}
