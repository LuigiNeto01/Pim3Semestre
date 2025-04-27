using Npgsql;
using System;

namespace Pim3Semestre.util
{
    internal static class Banco
    {
        private static readonly string connString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=Pim;";

        public static NpgsqlConnection AbrirConexao()
        {
            var conexao = new NpgsqlConnection(connString);
            conexao.Open();
            return conexao;
        }

        public static class Queries
        {
            public const string VerificarUsuarioExistente = @"
                SELECT 1
                FROM ""user""
                WHERE cpf = @cpf
                   OR email = @email
                   OR nome = @nome
                LIMIT 1;
            ";

            public const string InserirUsuario = @"
                INSERT INTO ""user"" (cpf, nome, email, senha, cargo)
                VALUES (@cpf, @nome, @email, @senha, @usuario);
            ";

            public const string LoginUsuario = @"
                SELECT id, cpf, nome, email, cargo, senha
                FROM ""user""
                WHERE nome = @nome
                  AND senha = @Senha
                LIMIT 1;
            ";

            public const string InserirTarefa = @"
                INSERT INTO chamados (titulo, motivo, descricao, prioridade, data_criacao, resolvido, id_usuario_criador)
                VALUES (@titulo, @motivo, @descricao, @prioridade, @data_criacao, @resolvido, @id_usuario_criador);
            ";

        }
    }
}
