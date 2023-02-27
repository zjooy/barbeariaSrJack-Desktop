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
        public static int codCliente, usuariotp;
        public static string nomeCliente, emailCliente, senhaCliente, statusCliente, fotoCliente;
        public static DateTime dataCadCliente;

        //Servico
        public static int codServico, idEmpresa;
        public static decimal valorServico;
        public static string nomeServico, statusServico, fotoServico, descricaoServico;
        public static DateTime dataCadServico, tempoExcServico;

        //Funcionario
        public static int codFuncionario, idEmpresaFunc;
        public static string nomeFuncionario, emailFuncionario, senhaFuncionario, nivelFuncionario, statusFuncionario, fotoFuncionario;
        public static DateTime dataCadFuncionario, horarioTrabalhoFuncionario;

        //FONE EMPRESA
        public static int codFoneEmpresa;
        public static string numeroFoneEmpresa, operadoraEmpresa, descricaoEmpresa;

        //FONE FUNCIONARIO
        public static int codFoneFuncionario;
        public static string numeroFoneFuncionario, operadoraFuncionario, descricaoFuncionario;

        //FONE CLIENTE
        public static int codFoneCliente;
        public static string numeroFoneCliente, operadoraCliente, descricaoCliente;

    }
}

