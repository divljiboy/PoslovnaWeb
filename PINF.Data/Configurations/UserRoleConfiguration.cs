using PINF.Model.Model;

namespace PINF.Data.Configurations
{
    public class UserRoleConfiguration : ModelBaseConfiguration<UserRole>
    {
        public UserRoleConfiguration()
        {
            Property(x => x.Role).IsRequired().HasMaxLength(100);
            Property(x => x.About).IsOptional().HasMaxLength(500);
        }
    }
}
