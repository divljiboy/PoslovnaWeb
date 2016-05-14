using PINF.Model.Model;

namespace PINF.Data.Configurations
{
    public class UserConfiguration : ModelBaseConfiguration<Korisnik>
    {
        public UserConfiguration()
        {
            Property(x => x.FirstName).IsOptional().HasMaxLength(50);
            Property(x => x.LastName).IsOptional().HasMaxLength(50);
            Property(x => x.Email).IsRequired().HasMaxLength(100);
            Property(x => x.Password).IsRequired();
            Property(x => x.Photo).IsOptional();
            Property(x => x.RoleId).IsRequired();
            Property(x => x.Activated).IsRequired();
        }
    }
}
