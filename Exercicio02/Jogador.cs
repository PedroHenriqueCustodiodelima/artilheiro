using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    class Jogador
    {
        private string nome;
        private int numero;
        private int gols;
        private int assitencia;
        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetAssistencia(int p)
        {
            if (p >= 0) assitencia = p;
        }
        public void SetNumero(int nu)
        {
            numero = nu;
        }
        public void SetGols(int g)
        {
            if (g >= 0 ) gols = g;
        }
        
        public string GetNome()
        {
            return nome;
        }
        public int GetNumero()
        {
            return numero;
        }
        public int GetGols()
        {
            return gols;
        }
        public int GetAssistencia()
        {
            return assitencia;
        }
        public override string ToString()
        {
            return $"Nome: {nome} - Camisa: {numero} - Gols: {gols} - Assistência: {assitencia}";
        }
    }
}
