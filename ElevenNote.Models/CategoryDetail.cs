using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevenNote.Data;

namespace ElevenNote.Models
{
    public class CategoryDetail
    {
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
        public ICollection<Note> Note { get; set; }
    }
}
