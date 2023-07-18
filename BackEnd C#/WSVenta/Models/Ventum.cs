﻿using System;
using System.Collections.Generic;

namespace WSVenta.Models;

public partial class Ventum
{
    public long Id { get; set; }

    public DateTime Fecha { get; set; }

    public int? IdCliente { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<Concepto> Conceptos { get; } = new List<Concepto>();

    public virtual Cliente? IdClienteNavigation { get; set; }
}
