using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;

namespace RealSurfClub.Models.DBModels
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Текст записи
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Изображение
        /// </summary>
        public Guid Photo { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// Автор записи
        /// </summary>
        public virtual User Author { get; set;}

    }
}