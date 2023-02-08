using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barbeariaSrJack
{
    public static class variaveis
    {
        //Geral
        public static string funcao;
        public static int linhaSelecionada;

        //Login
        public static string usuario, senha, nivel;

        //Empresa
        public static int codEmpresa;
        public static string nomeEmpresa, cnpjCpfEmpresa, razaoSocialEmpresa, emailEmpresa, statusEmpresa;
        public static DateTime dataCadEmpresa, horarioAtendEmpresa;

        //Cliente
        public static int codCliente;
        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente;
        public static DateTime dataCadCliente;

        //Funcionario
        public static int codFuncionario;
        public static string nomeFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, statusFuncionario, fotoFuncionario;
        public static DateTime dataCadFuncionario, horarioTrabalhoFuncionario;
    }
}

