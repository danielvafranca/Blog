﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Categories
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatorio")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Este campo deve conter entre 3 e 40 Caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O Slug é obrigatorio")]
        public string Slug { get; set; }
    }
}
