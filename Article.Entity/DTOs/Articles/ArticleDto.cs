﻿using Article.Entity.DTOs.Categories;
using Article.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article.Entity.DTOs.Articles
{
    public class ArticleDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public CategoryDto Category { get; set; }
        public DateTime CreatedDate { get; set; }  
        public Image Image { get; set; }    
        public AppUser User { get; set; }    
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; } 
        public int ViewCount { get; set; } 
    }
}
