﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TiendaPc.DLL.Models;

public partial class DetallePedido
{
    public int IdDetallePedido { get; set; }

    public int IdPedido { get; set; }

    public int? IdComponente { get; set; }

    public decimal? Descuento { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    [JsonIgnore]
    public virtual Componente IdComponenteNavigation { get; set; }
    [JsonIgnore]

    public virtual Pedido IdPedidoNavigation { get; set; }
}