using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GlucoControl.FrontEnd.Models
{
    public class ControlModel
    {
        [DisplayName("Fecha Control")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string ControlDate { get; set; }

        [DisplayName("Nivel Glucosa")]
        public int GlucoseLevel { get; set; }

        [DisplayName("Administrar Insulina")]
        public bool ProvideInsulin { get; set; }
    }
}
