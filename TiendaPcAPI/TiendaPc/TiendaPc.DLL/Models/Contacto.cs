﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TiendaPc.DLL.Models;

public partial class Contacto
{
    public int IdContacto { get; set; }

    public int IdTipoContacto { get; set; }

    public string Descripcion { get; set; }

    public bool? Principal { get; set; }

    public int? IdCliente { get; set; }

    public int? LegajoEmp { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; }

    public virtual TipoContacto IdTipoContactoNavigation { get; set; }

    public virtual Empleado LegajoEmpNavigation { get; set; }
}