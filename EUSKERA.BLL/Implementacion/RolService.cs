using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EUSKERA.BLL.Interfaces;
using EUSKERA.DAL.Interfaces;
using EUSKERA.Entity;

namespace EUSKERA.BLL.Implementacion
{
  public class RolService : IRolService
  {
    private readonly IGenericRepository<Rol> _repositorio;

    //Constructor de clase
    public RolService(IGenericRepository<Rol> repositorio)
    {
      _repositorio = repositorio;
    }

    //Devuelve la lista de roles
    public async Task<List<Rol>> Lista()
    {
      IQueryable<Rol> query = await _repositorio.Consultar();
      return query.ToList();
    }
  }
}
