using System;
using System.Collections.Generic;
using System.IO;
using Estacionamento1.Models;


namespace Estacionamento1.Repositorio {
    public class UsuarioRepositorio {
        public UsuarioModel CadastrarUsuario (UsuarioModel usuario) {
            if (File.Exists ("Registros.csv")) {
            }

            StreamWriter sw = new StreamWriter ("Registros.csv", true);
            sw.WriteLine ($"{usuario.NomeDoCondutor};{usuario.ModeloDoCarro};{usuario.MarcaDoCarro};{usuario.PlacaDoCarro};{usuario.DataEntrada}");
            sw.Close ();

            return usuario;
        }

        public List<UsuarioModel> Listar () {
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel> ();
            string[] linhas = File.ReadAllLines ("Registros.csv");
            UsuarioModel usuario;

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {

                    continue;
                }
                string[] linha = item.Split (";");

                usuario = new UsuarioModel (
                    nome: linha[0],
                    modelo: linha[1],
                    marca: linha[2],
                    placa: linhas[3],
                    dataEntrada: DateTime.Parse (linha[4])
                );
                listaDeUsuarios.Add (usuario);
            }
            return listaDeUsuarios;
        }

    }

}