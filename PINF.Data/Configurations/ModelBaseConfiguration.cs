using PINF.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Data.Configurations
{
    public class ModelBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IModelBase
    {
        public ModelBaseConfiguration()
        {
            HasKey(x => x.Id);
        }
    }
}
