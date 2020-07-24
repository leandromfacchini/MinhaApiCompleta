using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DevIo.Api.ViewModels;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIo.Api.Controllers
{
    [Route("api/{controller}")]
    public class FornecedoresController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository fornecedorRepository,
            IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<FornecedorViewModel>> ObterTodos()
        {
            var fornecedores = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());

            return fornecedores;
        }
    }
}