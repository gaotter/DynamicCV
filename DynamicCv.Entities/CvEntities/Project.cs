using Knowit.Amende.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DynamicCv.Entities.CvEntities
{
    public class Project
    {
        [Required]
        public DateTime From { get; set; }

        [NotMapped]
        public double FromAsUtcJsTicks
        {
            get
            {
                return From.ToJavaScriptUtcTicks();
            }
        }

        [Required]
        public DateTime To { get; set; }

        [NotMapped]
        public double ToAsUtcJSTicks
        {
            get
            {
                return To.ToJavaScriptUtcTicks();
            }
        }

        public int Id { get; set; }

        [Required]
        public string ProjectName { get; set; }

        public string ProjectDescription { get; set; }

        public virtual Entry Entry { get; set; }
    }
}
