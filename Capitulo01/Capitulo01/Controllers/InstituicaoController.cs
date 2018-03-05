﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capitulo01.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Capitulo01.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao(){
                InstituicaoID=1,
                Nome="UniParaná",
                Endereco="Paraná"
            },
            new Instituicao(){
                InstituicaoID=2,
                Nome="UniSanta",
                Endereco="Santa Catarina"
            },
            new Instituicao(){
                InstituicaoID=3,
                Nome="UniSãoPaulo",
                Endereco="São Paulo"
            },
            new Instituicao(){
                InstituicaoID=4,
                Nome="UniSulgrandense",
                Endereco="RionGRande do Sul"
            },
            new Instituicao(){
                InstituicaoID=5,
                Nome="UniCarioca",
                Endereco="Rio de Janeiro"
            }
        };
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(instituicoes);
        }
    }
}
