using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Naznean_LarisaGabriela_Laborator12.Models;

namespace Naznean_LarisaGabriela_Laborator12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
