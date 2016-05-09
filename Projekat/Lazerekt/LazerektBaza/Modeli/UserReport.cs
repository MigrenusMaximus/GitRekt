using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazerekt.LazerektBaza.Modeli
{
    class UserReport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int uid { get; set; }
    }
}