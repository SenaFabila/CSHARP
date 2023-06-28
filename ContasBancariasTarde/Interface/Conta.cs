using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Utilizar os códigos para o SQL Server
using System.Data.SqlClient;
using System.Data;

namespace Interface
{
    public class Conta
    {
        //prop + TAB + TAB
        public int agencia { get; set; }
        public int conta { get; set; }
        public decimal saldo { get; set; }
        public string tipo { get; set; }
        public string mensagem { get; set; }
        public decimal valorOperacao { get; set; }
    }

    //Herança - Classe que herda as propriedades de outra classe
    public class Corrente : Conta   //Extender
    {
        public decimal limite { get; set; }
    }

    public class Poupanca : Conta
    {
        public decimal taxa { get; set; }
    }

    public class CadastrarCCorrente
    {
        //Criação do método
        public void CadastrarDados(Corrente dados)
        {
            try //Tratamento de ERROS
            {
                //Comando do Banco de Dados - INSERT, UPDATE ou DELETE
                string sql = "INSERT INTO tbconta (coAgencia, coConta, coSaldo, coLimite, coTipo) " +
                "VALUES (@agencia, @conta, @saldo, @limite, @tipo)";

                //Preparação da conexão e comando SQL e seu tipo.
                SqlCommand cmd = new SqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text; //Procedure

                //Dados que serão substituídos no comando INSERT
                cmd.Parameters.Add(new SqlParameter("@agencia", dados.agencia));
                cmd.Parameters.Add(new SqlParameter("@conta", dados.conta));
                cmd.Parameters.Add(new SqlParameter("@saldo", dados.saldo));
                cmd.Parameters.Add(new SqlParameter("@limite", dados.limite));
                cmd.Parameters.Add(new SqlParameter("@tipo", dados.tipo));

                //Execução da Conexão e Comando SQL com retorno de linhas afetadas
                int registros = cmd.ExecuteNonQuery();

                //Analisar se houve linhas afetadas e indicar uma mensagem
                if (registros >= 1)
                {
                    dados.mensagem = "Cadastro realizado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao realizar cadastro!";
                }

                //Fechar a conexão com o Banco de Dados
                Conexao.fecharConexao();

            }
            //Armazenar as informações de erro caso aconteça
            catch (SqlException erro) 
            {
                dados.mensagem = "ERRO - CadastrarCCorrente - CadastrarDados " + erro.Message + " - " + erro.ErrorCode;
            }
        }
    }

    public class CadastrarCPoupanca
    {
        //Criação do método
        public void CadastrarDados(Poupanca dados)
        {
            try
            {
                string sql = "INSERT INTO tbconta (coAgencia, coConta, coSaldo, coTaxa, coTipo) " +
                "VALUES (@agencia, @conta, @saldo, @taxa, @tipo)";

                SqlCommand cmd = new SqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@agencia", dados.agencia));
                cmd.Parameters.Add(new SqlParameter("@conta", dados.conta));
                cmd.Parameters.Add(new SqlParameter("@saldo", dados.saldo));
                cmd.Parameters.Add(new SqlParameter("@taxa", dados.taxa));
                cmd.Parameters.Add(new SqlParameter("@tipo", dados.tipo));

                int registros = cmd.ExecuteNonQuery();

                if (registros >= 1)
                {
                    dados.mensagem = "Cadastro realizado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao realizar cadastro!";
                }

                Conexao.fecharConexao();

            }
            catch (SqlException erro)
            {
                dados.mensagem = "ERRO - CadastrarCPopanca - CadastrarDados " + erro.Message;
            }
        }
    }

    public class ListarContas : Conta
    {
        public DataTable ListarDadosContas()
        {
            DataTable tabela = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbconta";

                SqlDataAdapter adaptador =
                    new SqlDataAdapter(sql, Conexao.obterConexao());

                adaptador.Fill(tabela);

                Conexao.fecharConexao();
            }
            catch (SqlException erro)
            {
                mensagem = "ERRO - ListarContas - ListarDadosContas - " +
                    erro.Message.ToString();
            }
            return tabela;
        }
    }

    public class Saque
    {
        //Criação do método
        public void RealizarSaque(Conta dados)
        {
            try
            {
                string sql = "UPDATE tbconta SET coSaldo = coSaldo - @valorSaque WHERE coConta = @conta";

                SqlCommand cmd = new SqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@valorSaque", dados.valorOperacao));
                cmd.Parameters.Add(new SqlParameter("@conta", dados.conta));

                int registros = cmd.ExecuteNonQuery();

                if (registros >= 1)
                {
                    dados.mensagem = "Saque realizado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao realizar saque!";
                }

                Conexao.fecharConexao();

            }
            catch (SqlException erro)
            {
                dados.mensagem = "ERRO - Saque - RealizarSaque " + erro.Message;
            }
        }
    }

    public class Deposito
    {
        //Criação do método
        public void RealizarDeposito(Conta dados)
        {
            try
            {
                string sql = "UPDATE tbconta SET coSaldo = coSaldo + @valorDeposito WHERE coConta = @conta";

                SqlCommand cmd = new SqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@valorDeposito", dados.valorOperacao));
                cmd.Parameters.Add(new SqlParameter("@conta", dados.conta));

                int registros = cmd.ExecuteNonQuery();

                if (registros >= 1)
                {
                    dados.mensagem = "Depósito realizado com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao realizar Depósito!";
                }

                Conexao.fecharConexao();

            }
            catch (SqlException erro)
            {
                dados.mensagem = "ERRO - Deposito - RealizarDeposito " + erro.Message;
            }
        }
    }

    public class DeletarConta
    {
        //Criação do método
        public void RemoverConta(Conta dados)
        {
            try
            {
                string sql = "DELETE FROM tbconta WHERE coConta = @conta";

                SqlCommand cmd = new SqlCommand(sql, Conexao.obterConexao());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new SqlParameter("@conta", dados.conta));

                int registros = cmd.ExecuteNonQuery();

                if (registros >= 1)
                {
                    dados.mensagem = "Conta removida com Sucesso!";
                }
                else
                {
                    dados.mensagem = "Falha ao remover Conta!";
                }

                Conexao.fecharConexao();

            }
            catch (SqlException erro)
            {
                dados.mensagem = "ERRO - DeletarConta - RemoverConta " + erro.Message;
            }
        }
    }

}
