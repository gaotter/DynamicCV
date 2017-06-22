using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicCv.Entities.CvEntities
{
    public class Project
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string ProjectDescription { get; set; }

        public virtual Entry Entry { get; set; }
    }
}
