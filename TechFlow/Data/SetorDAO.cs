using SeuProjeto.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechFlow.Models;

namespace TechFlow.Data
{
    public class SetorDAO
    {
        // LISTAR
        public List<Setor> Listar()
        {
            var lista = new List<Setor>();

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"SELECT IdSetor, Nome FROM Setor";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Setor
                    {
                        IdSetor = dr.GetInt32(0),
                        Nome = dr.GetString(1)
                    });
                }
            }

            return lista;
        }

        // INSERIR
        public void Inserir(Setor s)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO Setor (Nome) VALUES (@Nome)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", s.Nome);

                cmd.ExecuteNonQuery();
            }
        }

        // ATUALIZAR
        public void Atualizar(Setor s)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
                    UPDATE Setor
                       SET Nome = @Nome
                     WHERE IdSetor = @IdSetor";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Nome", s.Nome);
                cmd.Parameters.AddWithValue("@IdSetor", s.IdSetor);

                cmd.ExecuteNonQuery();
            }
        }

        // EXCLUIR
        public void Excluir(int id)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"DELETE FROM Setor WHERE IdSetor = @IdSetor";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdSetor", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
