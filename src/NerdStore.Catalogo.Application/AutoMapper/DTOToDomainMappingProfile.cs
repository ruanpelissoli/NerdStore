﻿using AutoMapper;
using NerdStore.Catalogo.Application.DTOs;
using NerdStore.Catalogo.Domain;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    public class DTOToDomainMappingProfile : Profile
    {
        public DTOToDomainMappingProfile()
        {
            CreateMap<ProdutoDTO, Produto>()
                .ConstructUsing(p =>
                    new Produto(p.Nome, p.Descricao, p.Ativo,
                    p.Valor, p.CategoriaId, p.DataCadastro,
                    p.Imagem, new Dimensoes(p.Altura, p.Largura, p.Profundidade)));

            CreateMap<CategoriaDTO, Categoria>()
                .ConstructUsing(c => new Categoria(c.Nome, c.Codigo));
        }
    }
}
