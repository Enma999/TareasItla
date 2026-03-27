using ComunityWeb.Application.DTOs.CreateDTO;
using ComunityWeb.Infraestructure.Exceptions;
using ComunityWeb.Application.DTOs.Enums;
using ComunityWeb.Infraestructure.Interfaces;
using ComunityWeb.Infraestructure.Models;
using Mapster;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;
using ComunityWeb.Application.Contract;

namespace ComunityWeb.Application.Services
{
    public class CoordinatorService : ICoordinatorService
    {
        private readonly ICoordinatorRepository _coordinatorRepository;

        public CoordinatorService(ICoordinatorRepository coordinatorRepository)
        {
            _coordinatorRepository = coordinatorRepository;
        }

        public async Task<List<CoordinatorDTO>> GetAll()
        {
            var list = _coordinatorRepository.GetAll().Adapt<List<CoordinatorDTO>>();
            return list;
        }

        public async Task<CoordinatorDTO> GetById(int id)
        {
            var entity = await _coordinatorRepository.GetById(id);
            return entity.Adapt<CoordinatorDTO>();
        }

        public async Task<CoordinatorDTO> GetByNameAsync(string name)
        {
            var entity = _coordinatorRepository.GetAllByContainName(name);
            return entity.Adapt<CoordinatorDTO>();
        }
    }
}
