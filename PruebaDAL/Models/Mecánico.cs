﻿using System;
using System.Collections.Generic;

namespace PruebaDAL.Models
{
    public partial class Mecánico
    {
        public string DniUsuario { get; set; }
        public byte EsJefe { get; set; }
        public string Especialidad { get; set; }

        public virtual Usuario DniUsuarioNavigation { get; set; }
    }
}
