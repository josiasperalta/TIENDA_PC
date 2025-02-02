﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TiendaPc.DLL.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public int IdBarrio { get; set; }

    public int IdTipoDoc { get; set; }

    public string Documento { get; set; }

    public string Nombre { get; set; }

    public string Email { get; set; }

    public string Apellido { get; set; }

    public string Direccion { get; set; }

    public int NroCalle { get; set; }

    public bool? Estado { get; set; }

    [JsonIgnore]
    public virtual ICollection<Contacto> Contactos { get; set; } = new List<Contacto>();
    [JsonIgnore]

    public virtual Barrio IdBarrioNavigation { get; set; }
    [JsonIgnore]

    public virtual TipoDocumento IdTipoDocNavigation { get; set; }
    [JsonIgnore]
    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}