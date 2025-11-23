using System;
using System.Data;
using System.Data.SqlClient;
using TechFlow.Models;

namespace TechFlow.Data
{
    public class RelatorioDAO
    {
        private readonly string connectionString =
            "Server=tcp:techflow.database.windows.net,1433;" +
            "Initial Catalog=techflow;" +
            "Persist Security Info=False;" +
            "User ID=techflow;" +
            "Password=Pim@2025;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";

        // ============================================================
        // LISTAGENS PARA COMBOS
        // ============================================================
        public DataTable ListarTecnicos()
        {
            string sql = "SELECT IdTecnico, Nome FROM Tecnico ORDER BY Nome";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
        }

        public DataTable ListarSetores()
        {
            string sql = "SELECT IdSetor, Nome FROM Setor ORDER BY Nome";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
        }

        public DataTable ListarCategorias()
        {
            string sql = "SELECT IdCategoria, Nome FROM Categoria ORDER BY Nome";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
        }

        // ============================================================
        // RELATÓRIO COMPLETO
        // ============================================================
        public DataTable RelatorioCompleto()
        {
            string sql = @"
                SELECT 
                    c.IdChamado,
                    c.Titulo,
                    c.Descricao,
                    c.Status,
                    c.Prioridade,
                    c.DataAbertura,
                    c.DataFechamento,
                    u.Nome AS Usuario,
                    t.Nome AS Tecnico,
                    s.Nome AS Setor,
                    cat.Nome AS Categoria
                FROM Chamado c
                LEFT JOIN Usuario u ON c.UsuarioId = u.IdUsuario
                LEFT JOIN Usuario t ON c.TecnicoId = t.IdUsuario   
                LEFT JOIN Setor s ON c.IdSetor = s.IdSetor
                LEFT JOIN Categoria cat ON c.CategoriaId = cat.IdCategoria
                ORDER BY c.DataAbertura DESC;";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
        }

        // ============================================================
        // FILTRAR RELATÓRIO
        // ============================================================
        public DataTable FiltrarRelatorio(DateTime inicio, DateTime fim, string status, int? tecnico, int? setor, int? categoria)
        {
            string sql = @"
                            SELECT 
                                c.IdChamado,
                                c.Titulo,
                                c.Descricao,
                                c.Status,
                                c.Prioridade,
                                c.DataAbertura,
                                c.DataFechamento,
                                u.Nome AS Usuario,
                                t.Nome AS Tecnico,
                                s.Nome AS Setor,
                                cat.Nome AS Categoria
                            FROM Chamado c
                            LEFT JOIN Usuario u ON c.UsuarioId = u.IdUsuario     -- CORRIGIDO
                            LEFT JOIN Usuario t ON c.TecnicoId = t.IdUsuario     -- CORRIGIDO
                            LEFT JOIN Setor s ON c.IdSetor = s.IdSetor           -- CORRIGIDO (já estava ok)
                            LEFT JOIN Categoria cat ON c.CategoriaId = cat.IdCategoria -- CORRIGIDO
                            WHERE c.DataAbertura BETWEEN @inicio AND @fim";

            if (!string.IsNullOrEmpty(status))
                sql += " AND c.Status = @status";

            if (tecnico.HasValue)
                sql += " AND c.TecnicoId = @tecnico";  

            if (setor.HasValue)
                sql += " AND c.IdSetor = @setor";      

            if (categoria.HasValue)
                sql += " AND c.CategoriaId = @categoria"; 

            sql += " ORDER BY c.DataAbertura DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@inicio", inicio);
                cmd.Parameters.AddWithValue("@fim", fim);

                if (!string.IsNullOrEmpty(status))
                    cmd.Parameters.AddWithValue("@status", status);
                if (tecnico.HasValue)
                    cmd.Parameters.AddWithValue("@tecnico", tecnico);
                if (setor.HasValue)
                    cmd.Parameters.AddWithValue("@setor", setor);
                if (categoria.HasValue)
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    da.Fill(tabela);
                    return tabela;
                }
            }
        }


        // ============================================================
        // CARDS
        // ============================================================
        public int GetTotalChamados()
        {
            return ExecutarScalarInt("SELECT COUNT(*) FROM Chamado");
        }

        public int GetChamadosAbertos()
        {
            return ExecutarScalarInt("SELECT COUNT(*) FROM Chamado WHERE Status = 'Aberto'");
        }

        public int GetChamadosAtrasados()
        {
            string sql = @"
                SELECT COUNT(*) 
                FROM Chamado 
                WHERE Status <> 'Resolvido'
                AND DATEDIFF(DAY, DataAbertura, GETDATE()) > 7";

            return ExecutarScalarInt(sql);
        }

        private int ExecutarScalarInt(string sql)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // ============================================================
        // GRÁFICOS
        // ============================================================
        public DataTable GraficoPorStatus()
        {
            string sql = @"
                SELECT Status, COUNT(*) AS Qtd
                FROM Chamado
                GROUP BY Status";

            return CarregarTabela(sql);
        }

        public DataTable GraficoPorSetor()
        {
            string sql = @"
                SELECT s.Nome, COUNT(*) AS Qtd
                FROM Chamado c
                LEFT JOIN Setor s ON c.IdSetor = s.IdSetor
                GROUP BY s.Nome
                ORDER BY Qtd DESC";

            return CarregarTabela(sql);
        }

        public DataTable GraficoMensal()
        {
            string sql = @"
                SELECT 
                    DATENAME(MONTH, DataAbertura) AS Mes,
                    COUNT(*) AS Qtd
                FROM Chamado
                GROUP BY DATENAME(MONTH, DataAbertura), MONTH(DataAbertura)
                ORDER BY MONTH(DataAbertura)";

            return CarregarTabela(sql);
        }

        private DataTable CarregarTabela(string sql)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
            {
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
        }
    }
}
