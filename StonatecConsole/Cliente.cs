using System;
using System.Collections.Generic;
using System.Text;

namespace StonatecConsole
{
    class Cliente
    {
        public Cliente()
        {
            CriadoEm = DateTime.Now;
                
        }
        public string Clientes { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"equipamento: {Clientes} | Modelo: {Nome} |  Serial Number: {Cpf} | Criado em: {CriadoEm}";


        }

    }
}
