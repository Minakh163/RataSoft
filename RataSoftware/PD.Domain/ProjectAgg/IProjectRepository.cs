using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDetail.Domain.ProjectAgg
{
    public interface IProjectRepository
    {
        void Create(Project entity);
        Project Get(long id);
    }
}
