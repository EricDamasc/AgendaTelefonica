using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class clsAnotacoesDto
    {
        private int _idCodigo;
        private String _nome;
        private String _email;
        private String _cep;
        private String _estados;
        private String _cidades;
        private String _celular;
        private String _telefone;
        private String _anotacoes;

        public int IdCodigo
        {
            get { return _idCodigo; }
            set { _idCodigo = value; }
        }

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public String CEP
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public String Estados
        {
            get { return _estados; }
            set { _estados = value; }
        }

        public String Cidades
        {
            get { return _cidades; }
            set { _cidades = value; }
        }

        public String Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        public String Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public String Anotacao
        {
            get { return _anotacoes; }
            set { _anotacoes = value; }
        }
    }
}
