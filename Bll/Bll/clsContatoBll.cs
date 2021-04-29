using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using Dal;
using Dto;

namespace Bll
{
    public class clsContatoBll
    {
        private clsContatoDal _contato;

        /* Método construtor (Fundamentos POO) */

        public clsContatoBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _contato = new clsContatoDal();
        }

        public void Inserir(clsContatoDto contatoDto)
        {
            try
            {
                if (contatoDto.Nome.ToString() == String.Empty)
                {
                    throw new Exception("O campo Data é obrigatório!");
                }

                _contato.Inserir(contatoDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Alterar(clsContatoDto contatoDto)
        {
            try
            {
                if (contatoDto.Nome.ToString() == String.Empty)
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }

                _contato.Alterar(contatoDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public void Excluir(int contatoid)
        {
            try
            {
                if (contatoid <= 0)
                {
                    throw new Exception("O campo Código não pode ser zero ou negativo.");
                }

                _contato.Excluir(contatoid);
            }
            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }

        public List<clsContatoDto> ObterDados(int tipo, String nome)
        {
            clsContatoDal _contatoDal = new clsContatoDal();

            try
            {
                if ((nome == "") || (tipo == 1))
                {
                    return _contatoDal.obterDados(tipo, nome);
                }

                else
                {
                    throw new Exception("A informação do Tipo para a consulta não foi fornecedida!");
                }
            }

            catch (Exception ex)
            {
                throw new Exception("BLL: " + ex.Message);
            }
        }
    }
}