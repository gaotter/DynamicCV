using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DynamicCv.Entities.CvEntities
{
    public class Area
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual Entry Entry { get; set; }
    }
}
