
using System.Data.Entity;


public partial class Modtext : DbContext
{
    public Modtext() : base("DefaultConnection")
    {

    }
    public DbSet<People> people { get; set; }
}