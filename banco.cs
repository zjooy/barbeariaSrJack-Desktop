using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barbeariaSrJack
{
    public static class banco
    {
        //string conexão com o banco de dados
        public static string db = "SERVER=localhost;USER=root;DATABASE=barbeariajack"; //local


        //reconhecer biblioteca mysql
        public static MySqlConnection conexao;

        //Metodo para abrir conexao
        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao iniciar a conexão com o banco de dados..", "ERRO AO CONECTAR");
            }
        }


        //Metodo para fechar conexao
        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao encerrar a conexão com o banco de dados..", "ERRO AO DESCONECTAR");
            }
        }

    }
}
