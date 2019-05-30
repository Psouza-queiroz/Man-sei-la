using System;
using System.Collections.Generic;
using System.IO;
using Estacionamento1.Models;

namespace Estacionamento1.Repositorio {
    public class UsuarioRepositorio {
        public UsuarioModel CadastrarUsuario (UsuarioModel usuario) {
            if (!File.Exists ("Registros.csv")) {
                File.Create ("Registros.csv");
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
                string[] linha = item.Split (";");
                try {
                    System.Console.WriteLine (linha.Length);
                    System.Console.WriteLine (linha[0]);
                    System.Console.WriteLine (linha[1]);
                    System.Console.WriteLine (linha[2]);
                    System.Console.WriteLine (linha[3]);
                    System.Console.WriteLine (linha[4]);

                    usuario = new UsuarioModel(
                        nome: linha[0],
                        modelo: linha[1],
                        marca: linha[2],
                        placa: linha[3],
                        dataEntrada: DateTime.Parse(linha[4])
                    );
                    listaDeUsuarios.Add(usuario);   
                } catch (IndexOutOfRangeException ioore) {
                    System.Console.WriteLine ("Deu Out of Range");
                    System.Console.WriteLine (ioore.StackTrace);
                }
            }
            return listaDeUsuarios;
        }

    }
}

