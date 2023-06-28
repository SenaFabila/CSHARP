using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Interface.Properties;

namespace Interface
{
    public class Conexao
    {
        //Recebe as mensagens de erro do SqlException
        public static string mensagem = string.Empty;

        //Armazena a string de conexão em uma variável.
        private static string strConn = Settings.Default.strConexao;

        //Variável que receberá a conexão com o BD.
        private static SqlConnection conn = null;

        //Método para obter a conexão.
        //Com o atributo Static, não é necessário instanciar a classe para executar o método.
        public static SqlConnection obterConexao()
        {
            //Instanciar a classe de conexão
            conn = new SqlConnection(strConn);
            //Tratamento de exceções com Try{} catch{}.
            try
            {
                //Abre a conexão utilizando o método Open().
                conn.Open();
            }
            catch (SqlException erro) //Exception = Erro
            {
                //Define a variável como nulo se ocorrer erro.
                conn = null;
                //Apresenta a mensagem de exceção.
                mensagem = erro.ToString();
            }
            //Retorna o resultado da conexão.
            return conn;
        }

        //Método para fechar a conexão.
        public static SqlConnection fecharConexao()
        {
            //Instanciar a classe de conexão
            conn = new SqlConnection(strConn);
            //Tratamento de exceções com Try{} catch{}.
            try
            {
                //Fecha a conexão utilizando o método Close().
                conn.Close();
            }
            catch (SqlException erro)
            {
                //Define a variável como nulo se ocorrer erro.
                conn = null;
                //Apresenta a mensagem de exceção.
                mensagem = erro.ToString();
            }
            //Retorna o resultado da conexão.
            return conn;
        }
    }
}
