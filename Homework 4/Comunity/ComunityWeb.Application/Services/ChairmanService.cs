using ComunityWeb.Application.Contract;
using ComunityWeb.Application.DTOs.CreateDTO;
using ComunityWeb.Application.DTOs.Enums;
using ComunityWeb.Domain.Entities;
using ComunityWeb.Infraestructure.Exceptions;
using ComunityWeb.Infraestructure.Interfaces;
using ComunityWeb.Infraestructure.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComunityWeb.Application.Services
{
    public class ChairmanService : IChairmanService
    {
        private readonly IChairmanRepository _chairmanRepository;

        public ChairmanService(IChairmanRepository chairmanRepository)
        {
            _chairmanRepository = chairmanRepository;
        }

        public async Task<List<ChairmanDTO>> GetAll()
        {
            var list = _chairmanRepository.GetAll().Adapt<List<ChairmanDTO>>();
            return list;
        }

        public async Task<ChairmanDTO> GetById(int id)
        {
            var entity = await _chairmanRepository.GetById(id);
            return entity.Adapt<ChairmanDTO>();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetById(id);

            if (entity != null)
            {
                throw new ChairmanException("No se encontro el presidente en la base de datos");
            }

            var ent = entity.Adapt<ChairmanModel>();

            await _chairmanRepository.DeleteAsync(ent);
        }
    }
}
