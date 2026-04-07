using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

public class ProductInfoDAL : IProductInfoDAL
{
    private readonly string connectionString;

    public ProductInfoDAL()
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        connectionString = config.GetConnectionString("DefaultConnection");
    }

    public void InsertProduct(ProductInfo product)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_InsertProductInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@ListPrice", product.ListPrice);
            cmd.Parameters.AddWithValue("@ExpiryDate", (object)product.ExpiryDate ?? DBNull.Value);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public List<ProductInfo> GetAllProducts()
    {
        List<ProductInfo> list = new List<ProductInfo>();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_GetAllProductInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ProductInfo
                {
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString(),
                    ListPrice = Convert.ToDecimal(reader["ListPrice"]),
                    ExpiryDate = reader["ExpiryDate"] == DBNull.Value ? null : Convert.ToDateTime(reader["ExpiryDate"])
                });
            }
        }

        return list;
    }

    public void UpdateProduct(ProductInfo product)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_UpdateProductInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@ListPrice", product.ListPrice);
            cmd.Parameters.AddWithValue("@ExpiryDate", (object)product.ExpiryDate ?? DBNull.Value);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }

    public void DeleteProduct(int id)
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("sp_DeleteProductInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ProductId", id);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}