using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicCv.Entities.CvEntities
{
    public class Area
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual Entry Entry { get; set; }
    }
}
