using SeuProjeto.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechFlow.Models;

namespace TechFlow.Data
{
    public class AuditoriaDAO
    {
        public List<Auditoria> ListarTudo()
        {
            List<Auditoria> lista = new List<Auditoria>();

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT Id, DataAcao, Usuario, Acao, Descricao 
                               FROM Auditoria 
                               ORDER BY DataAcao DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Auditoria
                    {
                        Id = dr.GetInt32(0),
                        DataAcao = dr.GetDateTime(1),
                        Usuario = dr.GetString(2),
                        Acao = dr.GetString(3),
                        Descricao = dr.GetString(4)
                    });
                }
            }

            return lista;
        }

        public List<Auditoria> Filtrar(string usuario, string acao, DateTime? inicio, DateTime? fim)
        {
            List<Auditoria> lista = new List<Auditoria>();

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT Id, DataAcao, Usuario, Acao, Descricao
                    FROM Auditoria
                    WHERE 1 = 1";

                if (!string.IsNullOrEmpty(usuario))
                    sql += " AND Usuario LIKE @Usuario";

                if (!string.IsNullOrEmpty(acao))
                    sql += " AND Acao = @Acao";

                if (inicio.HasValue)
                    sql += " AND DataAcao >= @DataInicio";

                if (fim.HasValue)
                    sql += " AND DataAcao <= @DataFim";

                sql += " ORDER BY DataAcao DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);

                if (!string.IsNullOrEmpty(usuario))
                    cmd.Parameters.AddWithValue("@Usuario", "%" + usuario + "%");

                if (!string.IsNullOrEmpty(acao))
                    cmd.Parameters.AddWithValue("@Acao", acao);

                if (inicio.HasValue)
                    cmd.Parameters.AddWithValue("@DataInicio", inicio.Value);

                if (fim.HasValue)
                    cmd.Parameters.AddWithValue("@DataFim", fim.Value);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Auditoria
                    {
                        Id = dr.GetInt32(0),
                        DataAcao = dr.GetDateTime(1),
                        Usuario = dr.GetString(2),
                        Acao = dr.GetString(3),
                        Descricao = dr.GetString(4)
                    });
                }
            }

            return lista;
        }
    }
}
