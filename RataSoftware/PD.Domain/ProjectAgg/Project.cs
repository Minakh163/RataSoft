using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace projectDetail.Domain.ProjectAgg
{
    public class Project : EntityBase
    {
        public string ProjectName { get; private set; }
        public string CustomerName { get; private set; }
        public string ProjectType { get; private set; }


        public Project(string projectName, string customerName, string projectType)
        {
            ProjectName = projectName;
            CustomerName = customerName;
            ProjectType = projectType;

        }
    }


}
