using PINF.Data.Infrastructure;
using PINF.Data.Repositories;
using PINF.Model.Model;
using PINF.Service.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Service.Service
{
    public interface IUserService : IService<Korisnik>
    {

    }

    public class UserService : ServiceBase<Korisnik> , IUserService
    {
        private readonly IUserRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUserRepository repository, IUnitOfWork unitOfWork):
            base(repository, unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

    }
}
