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
    public class clsAnotacaoBll
    {
        private clsAnotacaoDal _anotacao;
        /* Método construtor (Fundamentos POO) */

        public clsAnotacaoBll()
        {
            /* Instanciando o objeto _cidades 
             * desta forma não será necessário
             * instancia-lo em cada método. */
            _anotacao = new clsAnotacaoDal();
        }

        public void Alterar(clsAnotacoesDto anotacaoDto)
        {
            try
            {
                if (anotacaoDto.Anotacao.ToString() == String.Empty)
                {
                    throw new Exception("O campo Anotações é obrigatório!");
                }

                _anotacao.Alterar(anotacaoDto);
            }
            catch (Exception ex)
            {
                /* Tratamento de erro que identifica a camada,
                 * muito interessante ser utilizado em proje-
                 * tos em camadas */
                throw new Exception("BLL: " + ex.Message);
            }
        }
        
        public List<clsAnotacoesDto> ObterDados(int tipo, String filtro)
        {
            clsAnotacaoDal _anotacaoDal = new clsAnotacaoDal();

            try
            {
                if ((tipo == 0) || (tipo == 1))
                {
                    return _anotacaoDal.obterDados(tipo, filtro);
                }

                else
                {
                    throw new Exception("A informação do Tipo para a consulta não foi fornecedida!");
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsAnotacoesDto> obterDados(int tipo, String filtro)
        {
            clsAnotacaoDal _anotacaoDal = new clsAnotacaoDal();

            try
            {

                if (tipo == 0 || tipo == 1)
                {
                    return _anotacaoDal.obterDados(tipo, filtro);
                }
                else
                {
                    throw new Exception("Não foi possivel realizar a busca");
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
