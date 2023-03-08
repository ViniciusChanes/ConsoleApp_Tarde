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
        public int Telefone;

        public Cliente(int id, string nome, int telefone)
        {
            ID = id;
            Nome = nome;
            Telefone = telefone;
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
        public int getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(int telefone)
        {
            Telefone = telefone;
        }
    }
}
