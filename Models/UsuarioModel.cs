using System;

namespace Estacionamento1.Models {
    public class UsuarioModel {

        public string NomeDoCondutor { get; set; }
        public string ModeloDoCarro { get; set; }
        public string MarcaDoCarro { get; set; }
        public string PlacaDoCarro { get; set; }
        public DateTime DataEntrada { get; set; }

        public UsuarioModel (string nome, string modelo, string marca, string placa, DateTime dataEntrada) {
            this.NomeDoCondutor = nome;
            this.ModeloDoCarro = modelo;
            this.MarcaDoCarro = marca;
            this.PlacaDoCarro = placa;
            this.DataEntrada = dataEntrada;
        }
        // public UsuarioModel(int id, string nome, string modelo, string marca, string placa, DateTime dataEntrada){

        //  this.NomeDoCondutor = nome;
        //this.ModeloDoCarro = modelo;
        //this.MarcaDoCarro = marca;
        //this.PlacaDoCarro = placa;
        //this.DataEntrada = dataEntrada;
    }

}