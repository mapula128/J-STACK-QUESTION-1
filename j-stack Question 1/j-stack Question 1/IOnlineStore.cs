using System;
using System.Collections.Generic;
using System.Text;

namespace j_stack_Question_1
{
  public interface IOnlineStore 

    {

        void AddProductsToInventory(ProductPurchaseOrder purchaseOrder);

        ProductSellOder SellProductsFromInventory(ProductSellOder itemSold);
        InventoryItemSummary GetInventoryItem(InventoryItemSummary stockType);

        InventorySummary GetInventorySummary();

    }
}
