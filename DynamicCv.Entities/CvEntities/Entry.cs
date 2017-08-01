using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Knowit.Amende.Helpers.Extensions;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace DynamicCv.Entities.CvEntities
{
    public class Entry
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

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

        public string ContentText { get; set; }

        public virtual IEnumerable<Area> Areas { get; set; }

        public virtual IEnumerable<Project> Projects { get; set; }

        public virtual CvUser User { get; set; }
    }
}
