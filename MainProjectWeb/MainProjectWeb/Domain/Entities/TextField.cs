using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MainProjectWeb.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } = "Инфомативная страница1";

        [Display(Name = "Содерждание страницы1")]
        public override string Text { get; set; } = "Содержимое заполняется администратором";
    }
}
