﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaPc.DLL.Models;

namespace TiendaPc.DLL.Services.Interfaces
{
    public interface IBarrioService
    {
        Task<List<Barrio>> GetAll();
        Task<List<Barrio>> GetBarriosByCiudadAsync(int idCiudad);
    }
}
