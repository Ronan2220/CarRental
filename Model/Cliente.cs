using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Model
{
    public class Cliente
    {
        private int idCliente;
        private string nome, cpf;
        private DateTime data_nasc;

        public Cliente()
        {
        }

        public Cliente(int idCliente ,string nome, string cpf, DateTime data_nasc)
        {
            idCliente = idCliente;
            Nome = nome;
            Cpf = cpf;
            Data_Nasc = data_nasc;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Cpf
        {
            get => cpf;
            set => cpf = value;
        }

        public DateTime Data_Nasc
        {
            get => data_nasc;
            set => data_nasc = value;
        }
    }
}
