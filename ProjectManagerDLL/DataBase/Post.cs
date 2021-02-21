namespace ProjectManagerDLL.DataBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        public int Id { get; set; }

        public int PostUser { get; set; }

        [Required]
        public string PostTitle { get; set; }

        [Required]
        public string PostContent { get; set; }

        public virtual Users Users { get; set; }
    }
}
