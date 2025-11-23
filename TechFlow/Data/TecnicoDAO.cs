using SeuProjeto.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechFlow.Models;

namespace TechFlow.Data
{
    public class TecnicoDAO
    {
        // ============================================
        // LISTAR TÉCNICOS
        // ============================================
        public List<Tecnico> Listar()
        {
            List<Tecnico> lista = new List<Tecnico>();

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT IdTecnico, Nome, Email, Especialidade, SetorId
                    FROM Tecnico";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Tecnico
                    {
                        IdTecnico = dr.GetInt32(0),
                        Nome = dr.GetString(1),
                        Email = dr.GetString(2),
                        Especialidade = dr.GetString(3),
                        SetorId = dr.IsDBNull(4) ? (int?)null : dr.GetInt32(4)
                    });
                }
            }

            return lista;
        }

        // ============================================
        // INSERIR
        // ============================================
        public void Inserir(Tecnico t)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    INSERT INTO Tecnico (Nome, Email, Especialidade, SetorId)
                    VALUES (@Nome, @Email, @Especialidade, @SetorId)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nome", t.Nome);
                cmd.Parameters.AddWithValue("@Email", t.Email);
                cmd.Parameters.AddWithValue("@Especialidade", t.Especialidade);
                cmd.Parameters.AddWithValue("@SetorId", (object)t.SetorId ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        // ============================================
        // ATUALIZAR
        // ============================================
        public void Atualizar(Tecnico t)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE Tecnico SET
                        Nome = @Nome,
                        Email = @Email,
                        Especialidade = @Especialidade,
                        SetorId = @SetorId
                    WHERE IdTecnico = @IdTecnico";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nome", t.Nome);
                cmd.Parameters.AddWithValue("@Email", t.Email);
                cmd.Parameters.AddWithValue("@Especialidade", t.Especialidade);
                cmd.Parameters.AddWithValue("@SetorId", (object)t.SetorId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@IdTecnico", t.IdTecnico);

                cmd.ExecuteNonQuery();
            }
        }

        // ============================================
        // EXCLUIR
        // ============================================
        public void Excluir(int id)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"DELETE FROM Tecnico WHERE IdTecnico = @IdTecnico";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdTecnico", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
