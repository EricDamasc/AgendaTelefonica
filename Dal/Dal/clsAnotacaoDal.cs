using Dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{

    public class clsAnotacaoDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;

        // METÓDO PARA ALTERAR ANOTAÇÕES
        public void Alterar(clsAnotacoesDto Anotacao)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
                 "UPDATE tblcontato " +
                " SET nome = '" + Anotacao.Nome + "'," +
                " email = '" + Anotacao.Email + "'," +
                " cep =  '" + Anotacao.CEP + "'," +
                " estados = '" + Anotacao.Estados + "'," +
                " cidades = '" + Anotacao.Cidades + "'," +
                " celular = '" + Anotacao.Celular + "'," +
                " anotacap = '" + Anotacao.Anotacao + "'" +
                " WHERE Idcodigo = '" + Anotacao.IdCodigo + "'";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }

        }

        public List<clsAnotacoesDto> obterDados(int tipo, String filtro)
        {
            List<clsAnotacoesDto> anotacaoDto = new List<clsAnotacoesDto>();

            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                if (tipo == 0)
                {
                    _comandoSql.CommandText = ("select Idcodigo, nome, email, cep, estados, cidades, celular, telefone, anotacap" +
                                              " from tblcontato");

                }
                else
                {
                    if (tipo == 1)
                    {
                        _comandoSql.CommandText = ("select Idcodigo, nome, email, cep, estados, cidades, celular, telefone, anotacap" +
                                              " from tblcontato " +
                                              " where nome like '" + filtro + "%'");
                    }

                }
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsAnotacoesDto anotacaoDtos = new clsAnotacoesDto();


                    anotacaoDtos.IdCodigo = Convert.ToInt32(_readersql["Idcodigo"].ToString());
                    anotacaoDtos.Nome = (_readersql["nome"].ToString());
                    anotacaoDtos.Email = (_readersql["email"].ToString());
                    anotacaoDtos.CEP = (_readersql["cep"].ToString());
                    anotacaoDtos.Estados = (_readersql["estados"].ToString());
                    anotacaoDtos.Cidades = (_readersql["cidades"].ToString());
                    anotacaoDtos.Celular = (_readersql["celular"].ToString());
                    anotacaoDtos.Telefone = (_readersql["telefone"].ToString());
                    anotacaoDtos.Anotacao = (_readersql["anotacap"].ToString());

                    anotacaoDto.Add(anotacaoDtos);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return anotacaoDto;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
