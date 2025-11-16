using ComunityWeb.Application.Contract;
using ComunityWeb.Application.DTOs.CreateDTO;
using ComunityWeb.Application.DTOs.Enums;
using ComunityWeb.Infraestructure.Exceptions;
using ComunityWeb.Infraestructure.Interfaces;
using ComunityWeb.Infraestructure.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.Services
{
    public class ActivistService : IActivistService
    {
        private readonly IActivistRepository _activistRepository;

        public ActivistService(IActivistRepository activistRepository)
        {
            _activistRepository = activistRepository;
        }

        public async Task<List<ActivistDTO>> GetAll()
        {
            var list = _activistRepository.GetAll().Adapt<List<ActivistDTO>>();
            return list;
        }

        public async Task<ActivistDTO> GetById(int id)
        {
            var entity = await _activistRepository.GetById(id);
            return entity.Adapt<ActivistDTO>();
        }

        public async Task<ActivistDTO> UpdateAsync(ActivistDTO entity, int id)
        {
            var activist = entity.Adapt<ActivistModel>();
            activist.Id = id;
            var result = await _activistRepository.UpdateAsync(activist);
            return result.Adapt<ActivistDTO>();
        }

        public async Task DeleteAsync(int Id)
        {
            var entity = await GetById(Id);

            if (entity == null)
            {
                throw new ActivistException("No se encontro el activista en la base de datos");
            }

            var ent = entity.Adapt<ActivistModel>();

            await _activistRepository.DeleteAsync(ent);
        }
    }
}
