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
    public class DespesaService: IDespesaService
    {
        private readonly IDespesaRepository _repository;
        private readonly ITipoGastoRepository _gastoRepository; 

        public DespesaService(IDespesaRepository repository, ITipoGastoRepository gastoRepository)
        {
            _repository = repository;
            _gastoRepository = gastoRepository;
        }

        public async Task<DespesaDto> Consultar(int? id)
        {
            var _despesa = await _repository.Consultar(id);
            DespesaDto despesaDto = new DespesaDto();

            if (_despesa != null)
            {
                var tipoGasto = await _gastoRepository.Consultar(_despesa.TipoGasto);
                despesaDto.Id = _despesa.Id;
                despesaDto.Observacao = _despesa.Descricao;                
                despesaDto.IdTipoGasto = _despesa.TipoGasto;
                despesaDto.ValorLancamento = _despesa.Valor;
                despesaDto.DataLancamento = _despesa.Data;
            }

            return despesaDto;
        }


        public async Task<bool> Create(DespesaDto despesaDto)
        {
            Domain.Entities.Despesa despesa = new Domain.Entities.Despesa();

            if (despesaDto != null)
            {
                //Despesa.Id = produtoDto.Id;
                despesa.Descricao = despesaDto.Observacao;
                despesa.TipoGasto = despesaDto.IdTipoGasto;
                despesa.Valor = despesaDto.ValorLancamento;
                despesa.Data = despesaDto.DataLancamento;
                try
                {
                    await _repository.Create(despesa);

                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public async Task<bool> Edit(DespesaDto despesaDto)
        {
            if (despesaDto != null)
            {
                if (despesaDto.Id > 0)
                {
                    Domain.Entities.Despesa despesa = new Domain.Entities.Despesa();

                    despesa.Id = despesaDto.Id;
                    despesa.Descricao = despesaDto.Observacao;
                    despesa.TipoGasto = despesaDto.IdTipoGasto;
                    despesa.Valor = despesaDto.ValorLancamento;
                    despesa.Data = despesaDto.DataLancamento;

                    try
                    {
                        await _repository.Edit(despesa);

                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                return false;
            }

            return false;
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _repository.Delete(id);

                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<IList<ListaDespesaDto>> ListDespesas()
        {
            var lista = await _repository.ListDespesas();

            IList<ListaDespesaDto> listaRetorno = new List<ListaDespesaDto>();

            foreach (Domain.Entities.Despesa _despesa in lista)
            {
                var tipoGasto = await _gastoRepository.Consultar(_despesa.TipoGasto);

                ListaDespesaDto newDesp = new ListaDespesaDto();
                newDesp.Id = _despesa.Id;
                newDesp.DescricaoGeral = _despesa.Descricao;
                newDesp.DescicaoTipoGasto = tipoGasto.Descricao;
                newDesp.CodTipoGasto = _despesa.TipoGasto;
                newDesp.ValorGasto = _despesa.Valor;
                newDesp.DataGasto = _despesa.Data;

                listaRetorno.Add(newDesp);
            }

            return listaRetorno;
        }
    }
}
