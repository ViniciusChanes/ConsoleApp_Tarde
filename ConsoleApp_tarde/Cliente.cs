using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde
{
    public class Cliente
    {
        public int ID;
        public string Nome;
        public string Telefone;
        private Endereco Endereco;

        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            ID = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public Endereco getEndereco()
        {
            return Endereco;
        }

        public int getID()
        {
            return ID;
        }

        public void setID(int id)
        {
            ID = id;
        }
        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public string ClienteCompleto()
        {

            return "ID: " + ID + " Nome: " + Nome + " Telefone: " + Telefone + " Endereco: " + Endereco.EnderecoCompleto();

        }
    }
}
