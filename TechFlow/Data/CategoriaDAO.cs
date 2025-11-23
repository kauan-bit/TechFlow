using SeuProjeto.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechFlow.Models;

namespace TechFlow.Data
{
    public class CategoriaDAO
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT IdCategoria, Nome 
                           FROM Categoria
                           ORDER BY Nome";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Categoria
                    {
                        IdCategoria = dr.GetInt32(0),
                        Nome = dr.GetString(1)
                    });
                }
            }

            return lista;
        }

        public void Inserir(Categoria c)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Categoria (Nome)
                           VALUES (@Nome)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", c.Nome);

                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(Categoria c)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE Categoria 
                           SET Nome = @Nome
                           WHERE IdCategoria = @IdCategoria";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", c.Nome);
                cmd.Parameters.AddWithValue("@IdCategoria", c.IdCategoria);

                cmd.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"DELETE FROM Categoria 
                           WHERE IdCategoria = @Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
        }
    }

}
