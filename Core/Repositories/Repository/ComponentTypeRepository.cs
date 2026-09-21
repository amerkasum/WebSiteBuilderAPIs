using Core.EF;
using Core.Repositories.IRepository;
using Domain.Entities.WebSiteBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories.Repository
{
    public class ComponentTypeRepository : Repository<ComponentType>, IComponentTypeRepository
    {
        public ComponentTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
