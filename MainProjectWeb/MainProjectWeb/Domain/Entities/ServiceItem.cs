﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainProjectWeb.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Заполните название товара")]

        [Display(Name ="Название товара")]
        public override string Title { get; set; }

        [Display(Name = "Краткое описание товара")]
        public override string Subtitle { get; set; }

        [Display(Name ="Полное описание товара")]
        public override string Text { get; set; }
    }
}