using Encapsulamento.Demo.Api.DTOs;
using Encapsulamento.Demo.Domain.Entities;
using Encapsulamento.Demo.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Encapsulamento.Demo.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService) =>
        _clienteService = clienteService;

    [HttpGet("{codigo}")]
    public async Task<ActionResult<Cliente?>> Obter(int codigo)
    {
        var cliente = await _clienteService.ObterClientePorCodigo(codigo);
        if (cliente != null)
            return Ok(cliente);
        return NotFound();
    }

    [HttpPost]
    public async Task<ActionResult<int>> Inserir(ClienteDTO clienteDTO)
    {
        var cliente = ClienteDTO.ConverterParaEntidade(clienteDTO);
        await _clienteService.InserirCliente(cliente);
        return CreatedAtAction(nameof(Obter), new {codigo = cliente.Codigo}, cliente.Codigo);
    }

    [HttpPost("{codigo}/tornar-premium")]
    public async Task<ActionResult<int>> TornarClientePremium(int codigo)
    {
        await _clienteService.TornarClientePremium(codigo);
        return Ok();
    }

    [HttpPost("{codigo}/desativar")]
    public async Task<ActionResult<int>> DesativarCliente(int codigo)
    {
        await _clienteService.DesativarCliente(codigo);
        return Ok();
    }
}
