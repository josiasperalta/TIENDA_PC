﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TiendaPc.DLL.Models;

public partial class TipoDocumento
{
    public int IdTipoDoc { get; set; }

    public string NombreTipoDocumento { get; set; }

    [JsonIgnore]
    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
    [JsonIgnore]

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
}