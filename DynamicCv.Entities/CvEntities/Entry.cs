using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicCv.Entities.CvEntities
{
    public class Entry
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ContentText { get; set; }

        public virtual IEnumerable<Area> Areas { get; set; }

        public virtual IEnumerable<Project> Projects { get; set; }
    }
}
