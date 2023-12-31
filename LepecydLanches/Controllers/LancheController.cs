﻿using LepecydLanches.Models;
using LepecydLanches.Repositories.Interfaces;
using LepecydLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LepecydLanches.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os Lanches";
            }
            else
            {
                /*if (string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                        .OrderBy(l => l.Nome);
                    categoriaAtual = "Normais";
                }
                else
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l=>l.Categoria.CategoriaNome.Equals("Natural"))
                        .OrderBy(l => l.Nome);
                    categoriaAtual = "Naturais";
                }*/
                lanches = _lancheRepository.Lanches
                      .Where(a => a.Categoria.CategoriaNome.Equals(categoria));
                categoriaAtual = categoria;
            }

            var lancheListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };
            return View(lancheListViewModel);
        }

        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRepository.Lanches.FirstOrDefault(l=>l.LancheId == lancheId);
            return View(lanche);
        }
    }
}
