using ComunityWeb.Application.Contract;
using ComunityWeb.Application.DTOs.CreateDTO;
using ComunityWeb.Application.DTOs.Enums;
using ComunityWeb.Infraestructure.Exceptions;
using ComunityWeb.Infraestructure.Interfaces;
using ComunityWeb.Infraestructure.Models;
using Mapster;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComunityWeb.Application.Services
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _repository;

        public MemberService(IMemberRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MemberDTO>> GetAll()
        {
            var list = _repository.GetAll().Adapt<List<MemberDTO>>();
            return list;
        }

        public async Task<MemberDTO> GetById(int ID)
        {
            var entity = await _repository.GetById(ID);
            return entity.Adapt<MemberDTO>();
        }

        public async Task<MemberDTO> AddAsync(MemberCDTO entity)
        {
            var member = entity.Adapt<MemberModel>();
            var result = await _repository.AddAsync(member);
            return result.Adapt<MemberDTO>();
        }

        public async Task<MemberDTO> UpdateAsync(MemberDTO entity, int ID)
        {
            var member = entity.Adapt<MemberModel>();
            member.Id = ID;
            var result = await _repository.UpdateAsync(member);
            return result.Adapt<MemberDTO>();
        }

        public async Task DeleteAsync(int ID)
        {
            var entity = await GetById(ID);

            if (entity == null)
            {
                throw new MemberException("No se encontro el miembro en la base de datos");
            }

            var ent = entity.Adapt<MemberModel>();

            await _repository.DeleteAsync(ent);
        }

        public async Task<List<MemberDTO>> GetByNameAsync(string name)
        {
            var entity = await _repository.GetAllByContainName(name);
            return entity.Adapt<List<MemberDTO>>();
        }
    }
}
