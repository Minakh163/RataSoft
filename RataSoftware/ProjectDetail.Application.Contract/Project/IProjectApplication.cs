using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDetail.Application.Contract.Project
{
    public interface IProjectApplication
    {
        void Create(CreateProject Command);
        void Edit(EditProject Command);
    }
}
