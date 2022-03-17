﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebJournal.Model
{
    public class Post : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public string SubTitle { get; set; }
        
        [Required]
        public string Description { get; set; }
        public List<Comment> Comments { get; set; }
        public Category Category { get; set; }
    }
}
