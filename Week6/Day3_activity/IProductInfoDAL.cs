using System.Collections.Generic;

public interface IProductInfoDAL
{
    void InsertProduct(ProductInfo product);
    List<ProductInfo> GetAllProducts();
    void UpdateProduct(ProductInfo product);
    void DeleteProduct(int id);
}