using DirectManagement.DOMAIN.Entities.BaseEntitiy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DOMAIN.Entities.Concretes
{
    public class Files : Base
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Storage { get; set; }
        [NotMapped]
        public DateTime UpdateDate { get => UpdateDate; set => base.UpdateDate = value; }
    }
}
