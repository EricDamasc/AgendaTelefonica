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
    public class clsContatoDal
    {
        private SqlConnection _conexao;
        private SqlCommand _comandoSql;
        private SqlDataReader _readersql;

        public DataTable ObterDados(int tipo, String filtro)
        {
            try
            {
                if (tipo == 0)
                {
                    return Conexao.obterDados("SELECT DATEPART ( DAY , '10/01/2021' )");
                }
                else if (tipo == 1)
                {
                    return Conexao.obterDados("SELECT DATEPART ( MONTH , '10/01/2021' )");
                }

                else if (tipo == 2)
                {
                    return Conexao.obterDados("SELECT DATEPART ( YEAR , '10/01/2021' )");
                }

                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        private Int32 obterProximocodigo()
        {

            Int32 proximoNum;

            _conexao = Conexao.ObterConexao();

            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;
            _comandoSql.CommandText = "SELECT ISNULL((MAX(idcodigo) + 1), 1) AS proximoNum FROM tblcontato";

            proximoNum = int.Parse(_comandoSql.ExecuteScalar().ToString());

            Conexao.fecharConexao(_conexao);
            return proximoNum;

        }

        // METÓDO PARA INSERIR Contato
        public void Inserir(clsContatoDto Contato)
        {
            try
            {
                 Contato.IdCodigo = obterProximocodigo();
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "INSERT INTO tblcontato (Idcodigo, nome, email, cep, estados, cidades, celular, telefone, anotacap) " +
                "VALUES " +
                "(" + Contato.IdCodigo + ",'" + Contato.Nome + "','" + Contato.Email + "','" + Contato.CEP + "','" + Contato.Estados + 
                "','" + Contato.Cidades + "','" + Contato.Celular + "','" + Contato.Telefone + "','" + Contato.Anotacao + "')";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        // METÓDO PARA ALTERAR CONTATO
        public void Alterar(clsContatoDto Contato)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
                "UPDATE tblcontato " +
                " SET nome = '" + Contato.Nome + "'," +
                " email = '" + Contato.Email + "'," +
                " cep =  '" + Contato.CEP + "'," +
                " estados = '" + Contato.Estados + "'," +
                " cidades = '" + Contato.Cidades + "'," +
                " celular = '" + Contato.Celular + "'," +
                " anotacap = '" + Contato.Anotacao + "'" +
                " WHERE Idcodigo = '" + Contato.IdCodigo + "'";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }

        }

        // METÓDO PARA EXCLUIR CONTATO
        public void Excluir(int Idcodigo)
        {
            try
            {
                _conexao = Conexao.ObterConexao();

                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText = "DELETE FROM tblcontato WHERE Idcodigo = " + Idcodigo + "";

                _comandoSql.ExecuteNonQuery();
                Conexao.fecharConexao(_conexao);
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<clsContatoDto> obterdadosCombo()
        {
            List<clsContatoDto> contatoDtos = new List<clsContatoDto>();

            _conexao = Conexao.ObterConexao();
            _comandoSql = new SqlCommand();
            _comandoSql.Connection = _conexao;

            _comandoSql.CommandText = ("select Idcodigo, nome, email, cep, estados, cidades, celular, telefone, anotacap" +
                                        " from tblcontato");


            _readersql = _comandoSql.ExecuteReader();
            while (_readersql.Read())
            {
                clsContatoDto contatoDto = new clsContatoDto();

                contatoDto.IdCodigo = Convert.ToInt32(_readersql["Idcodigo"].ToString());
                contatoDto.Nome = (_readersql["nome"].ToString());
                contatoDto.Email = (_readersql["email"].ToString());
                contatoDto.CEP = (_readersql["cep"].ToString());
                contatoDto.Estados = (_readersql["estados"].ToString());
                contatoDto.Cidades = (_readersql["cidades"].ToString());
                contatoDto.Celular = (_readersql["celular"].ToString());
                contatoDto.Telefone = (_readersql["telefone"].ToString());
                contatoDto.Anotacao = (_readersql["anotacap"].ToString());

                contatoDtos.Add(contatoDto);
            }
            _readersql.Close();

            Conexao.fecharConexao(_conexao);
            return contatoDtos;
        }

        public List<clsContatoDto> obterDados(int tipo, String nome)
        {
            List<clsContatoDto> contatosDtos = new List<clsContatoDto>();
            
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
                    if (nome != "")
                    {
                        _comandoSql.CommandText = ("select * from tblcontato where nome like '" + nome + "%'");
                    }

                }
                _readersql = _comandoSql.ExecuteReader();
                while (_readersql.Read())
                {
                    clsContatoDto contatoDto = new clsContatoDto();

                    contatoDto.IdCodigo = Convert.ToInt32(_readersql["Idcodigo"].ToString());
                    contatoDto.Nome = (_readersql["nome"].ToString());
                    contatoDto.Email = (_readersql["email"].ToString());
                    contatoDto.CEP = (_readersql["cep"].ToString());
                    contatoDto.Estados = (_readersql["estados"].ToString());
                    contatoDto.Cidades = (_readersql["cidades"].ToString());
                    contatoDto.Celular = (_readersql["celular"].ToString());
                    contatoDto.Telefone = (_readersql["telefone"].ToString());
                    contatoDto.Anotacao = (_readersql["anotacap"].ToString());

                    contatosDtos.Add(contatoDto);
                }
                _readersql.Close();

                Conexao.fecharConexao(_conexao);

                return contatosDtos;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public string ObterCombo(int codigo)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;

                _comandoSql.CommandText =
                    "select nome " +
                     "  from tblcontato" +
                     " where nome = @nome";

                _comandoSql.Parameters.Add("@nome", SqlDbType.Int).Value = codigo;

                string x = _comandoSql.ExecuteScalar().ToString();
                Conexao.fecharConexao(_conexao);
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public String obternome(String nome)
        {
            try
            {
                _conexao = Conexao.ObterConexao();
                _comandoSql = new SqlCommand();
                _comandoSql.Connection = _conexao;
                _comandoSql.CommandText =
                     "select datadacorrida from tblcontato where datadacorrida = " + nome;

                //_comandoSql.Parameters.Add("@estid", SqlDbType.Int).Value = codigo;

                String x = _comandoSql.ExecuteScalar().ToString();
                Conexao.fecharConexao(_conexao);
                return x;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
