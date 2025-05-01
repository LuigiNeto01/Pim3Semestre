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
            // 🔍 VALIDAÇÕES
            public const string VerificarUsuarioExistente = @"
                SELECT 1
                FROM ""user""
                WHERE cpf = @cpf
                   OR email = @email
                   OR nome = @nome
                LIMIT 1;
            ";

            // ➕ INSERÇÕES
            public const string InserirUsuario = @"
                INSERT INTO ""user"" (cpf, nome, email, senha, cargo)
                VALUES (@cpf, @nome, @email, @senha, @usuario);
            ";

            public const string InserirTarefa = @"
                INSERT INTO chamados (titulo, motivo, descricao, prioridade, data_criacao, resolvido, id_usuario_criador)
                VALUES (@titulo, @motivo, @descricao, @prioridade, @data_criacao, @resolvido, @id_usuario_criador);
            ";

            // 🔐 LOGIN
            public const string LoginUsuario = @"
                SELECT id, cpf, nome, email, cargo, senha, nivel
                FROM ""user""
                WHERE nome = @nome AND senha = @Senha
                LIMIT 1;

            ";

            // 🛠️ ATUALIZAÇÕES
            public const string SalvarEditarPerfil = @"
                UPDATE ""user""
                SET nome = @nome,
                    email = @email,
                    senha = @senha
                WHERE cpf = @cpf;
            ";

            // 📊 CONTADORES
            public const string contarCriticos = @"
                SELECT COUNT(*) FROM chamados 
                WHERE prioridade = 1 AND id_usuario_criador = @id;
            ";

            public const string contarCriticosAdmin = @"
                SELECT COUNT(*) FROM chamados 
                WHERE prioridade = 1;
            ";

            public const string contarFechados = @"
        SELECT COUNT(*) FROM chamados 
        WHERE resolvido = true AND id_usuario_criador = @id;
    ";

            public const string contarFechadosAdmin = @"
        SELECT COUNT(*) FROM chamados 
        WHERE resolvido = true;
    ";

            public const string contarAbertos = @"
        SELECT COUNT(*) FROM chamados 
        WHERE resolvido = false AND id_usuario_criador = @id;
    ";

            public const string contarAbertosAdmin = @"
        SELECT COUNT(*) FROM chamados 
        WHERE resolvido = false;
    ";

            // 📄 LISTAGEM DE CHAMADOS
            public const string ListarChamadosUser = @"
        SELECT id, titulo, motivo, prioridade, resolvido, descricao
        FROM chamados 
        WHERE id_usuario_criador = @id_usuario 
        ORDER BY data_criacao DESC;
    ";

            public const string ListarChamadosAdmin = @"
    SELECT chamados.id, titulo, motivo, descricao, prioridade, resolvido, u.nome AS nome_criador
    FROM chamados
    INNER JOIN ""user"" u ON u.id = chamados.id_usuario_criador
    ORDER BY data_criacao DESC;
";
        }
    }
}
