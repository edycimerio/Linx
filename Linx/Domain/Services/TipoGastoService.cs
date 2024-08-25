using Domain.Dtos;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{    
    public class TipoGastoService : ITipoGastoService
    {
        private readonly ITipoGastoRepository _repository;

        public TipoGastoService(ITipoGastoRepository repository)
        {
            _repository = repository;
        }

        public async Task<TipoGastoDto> Consultar(int? id)
        {
            var _tipo = await _repository.Consultar(id);
            TipoGastoDto tipo = new TipoGastoDto();

            if (_tipo != null)
            {
                tipo.Codigo = _tipo.Id;
                tipo.NomeGasto = _tipo.Descricao;
            }

            return tipo;
        }

        public async Task<IList<TipoGastoDto>> ListTipoGastos()
        {
            var lista = await _repository.ListTipoGastos();

            IList<TipoGastoDto> listaRetorno = new List<TipoGastoDto>();

            foreach (TipoGastos tipo in lista)
            {
                TipoGastoDto newTipo = new TipoGastoDto();
                newTipo.Codigo = tipo.Id;
                newTipo.NomeGasto = tipo.Descricao;

                listaRetorno.Add(newTipo);
            }

            return listaRetorno;
        }

        public async Task<bool> Create(TipoGastoDto tipo)
        {
            Domain.Entities.TipoGastos tipoGastos = new Domain.Entities.TipoGastos();

            if (tipo != null)
            {
                //Despesa.Id = produtoDto.Id;
                tipoGastos.Descricao = tipo.NomeGasto;
               
                try
                {
                    await _repository.Create(tipoGastos);

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }


    }
}
