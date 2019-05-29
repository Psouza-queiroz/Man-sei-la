using System;
using Estacionamento1.Models;
using Estacionamento1.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento1.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Index(){

            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(
                nome: form["Nome"],
                modelo: form["Modelo"],
                marca: form["Marca"],
                placa: form["Placa"],
                dataEntrada: DateTime.Parse(form["DatadeEntrada"])
                
            );

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.CadastrarUsuario(usuario);
            
            return RedirectToAction("Index","Usuario");
        }

        [HttpGet]
        public IActionResult Listar(){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.Listar();

            return View();
        }
        
        
    }

}