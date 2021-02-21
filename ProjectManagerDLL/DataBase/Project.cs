namespace ProjectManagerDLL.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        public int Id { get; set; }

        public int UserPublishing { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        public string ProjectScope { get; set; }

        public int NumberOfPeople { get; set; }

        [Required]
        public string ProjectSection { get; set; }

        public virtual Users Users { get; set; }
    }
}
