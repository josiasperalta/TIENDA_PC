﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TiendaPc.DLL.Models;

public partial class TipoContacto
{
    public int IdTipoContacto { get; set; }

    public string Descripcion { get; set; }
    [JsonIgnore]

    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();
}