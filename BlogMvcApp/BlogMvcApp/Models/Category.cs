﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public List<Blog> Bloglar { get; set; }
    }
}