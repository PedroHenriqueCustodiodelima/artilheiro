using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    class time
    {
        private string nome_time;
        private string estado;
        public void SetNome_time(string nt)
        {
            nome_time = nt;
        }
        public void SetEstado(string e)
        {
            estado = e;
        }
        public string GetNome_time()
        {
            return nome_time;
        }
        public string GetEstado()
        {
            return estado;
        }
        public override string ToString()
        {
            return $"Time: {nome_time} - Estado: {estado}";
        }
    }
}
