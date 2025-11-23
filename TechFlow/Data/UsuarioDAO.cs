using SeuProjeto.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechFlow.Models;

namespace TechFlow.Data
{
    public class UsuarioDAO
    {
        // ============================================
        // LISTAR TODOS OS USUÁRIOS
        // ============================================
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    SELECT IdUsuario, Nome, Email, SenhaHash, Perfil, SetorId
                    FROM Usuario";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Usuario
                    {
                        IdUsuario = dr.GetInt32(0),
                        Nome = dr.GetString(1),
                        Email = dr.GetString(2),
                        SenhaHash = dr.GetString(3),
                        Perfil = dr.GetString(4),
                        SetorId = dr.IsDBNull(5) ? (int?)null : dr.GetInt32(5)
                    });
                }

                dr.Close();
            }

            return lista;
        }

        // ============================================
        // INSERIR USUÁRIO
        // ============================================
        public void Inserir(Usuario u)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    INSERT INTO Usuario (Nome, Email, SenhaHash, Perfil, SetorId)
                    VALUES (@Nome, @Email, @Senha, @Perfil, @SetorId)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Senha", u.SenhaHash);
                cmd.Parameters.AddWithValue("@Perfil", u.Perfil);
                cmd.Parameters.AddWithValue("@SetorId", (object)u.SetorId ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        // ============================================
        // ATUALIZAR USUÁRIO
        // ============================================
        public void Atualizar(Usuario u)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE Usuario SET
                        Nome = @Nome,
                        Email = @Email,
                        Perfil = @Perfil,
                        SetorId = @SetorId
                    WHERE IdUsuario = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Perfil", u.Perfil);
                cmd.Parameters.AddWithValue("@SetorId", (object)u.SetorId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Id", u.IdUsuario);

                cmd.ExecuteNonQuery();
            }
        }

        // ============================================
        // EXCLUIR USUÁRIO
        // ============================================
        public void Excluir(int id)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"DELETE FROM Usuario WHERE IdUsuario = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public Usuario Login(string email, string senha)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                SELECT IdUsuario, Nome, Email, Perfil, SetorId
                FROM Usuario
                WHERE Email = @Email AND SenhaHash = @Senha";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Usuario
                    {
                        IdUsuario = dr.GetInt32(0),
                        Nome = dr.GetString(1),
                        Email = dr.GetString(2),
                        Perfil = dr.GetString(3),
                        SetorId = dr.IsDBNull(4) ? (int?)null : dr.GetInt32(4)
                    };
                }

                return null;
            }
        }

    }
}
