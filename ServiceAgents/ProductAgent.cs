using System;
using HandsOnLab1.ClientEntities;

namespace HandsOnLab1.ServiceAgents
{
    public class ProductAgent
    {
        public static ProductSummaryCollection GetProductList()
        {
            ProductSummaryCollection products = new ProductSummaryCollection();
            
            ProductSummary prod = new ProductSummary();

            prod.ProductId = 1;
            prod.Sku = "0001-unit";
            prod.Code = "0001";
            prod.Name = "Tomcats DVD";
            prod.ShortDescription = "Tomcats DVD Zone 4";
            prod.Manufacturer = "Revolution Studios";
            prod.LowestPrice = 10;
            prod.UnitPrice = 12;
            products.Add(prod);

            prod = new ProductSummary();
            prod.ProductId = 2;
            prod.Sku = "0002-unit";
            prod.Code = "0002";
            prod.Name = "Top Gun DVD";
            prod.ShortDescription = "Top Gun DVD Zone 4";
            prod.Manufacturer = "Paramount Pictures";
            prod.LowestPrice = 15;
            prod.UnitPrice = 25;
            products.Add(prod);

            prod = new ProductSummary();
            prod.ProductId = 3;
            prod.Sku = "0003-unit";
            prod.Code = "0003";
            prod.Name = "Total Recall DVD";
            prod.ShortDescription = "Total Recall DVD Zone 4";
            prod.Manufacturer = "Carolco International N.V.";
            prod.LowestPrice = 5;
            prod.UnitPrice = 5;
            products.Add(prod);

            prod = new ProductSummary();
            prod.ProductId = 4;
            prod.Sku = "0004-unit";
            prod.Code = "0004";
            prod.Name = "Trainspotting DVD";
            prod.ShortDescription = "Trainspotting DVD Zone 4";
            prod.Manufacturer = "Channel Four Films";
            prod.LowestPrice = 52;
            prod.UnitPrice = 60;
            products.Add(prod);

            prod = new ProductSummary();
            prod.ProductId = 5;
            prod.Sku = "0005-unit";
            prod.Code = "0005";
            prod.Name = "True Lies DVD";
            prod.ShortDescription = "True Lies DVD Zone 4";
            prod.Manufacturer = "Lightstorm Entertainment";
            prod.LowestPrice = 9;
            prod.UnitPrice = 15;
            products.Add(prod);

            prod = new ProductSummary();
            prod.ProductId = 6;
            prod.Sku = "0006-unit";
            prod.Code = "0006";
            prod.Name = "Two Hands DVD";
            prod.ShortDescription = "Two Hands DVD Zone 4";
            prod.Manufacturer = "CML Films";
            prod.LowestPrice = 5;
            prod.UnitPrice = 8;
            products.Add(prod);

            prod = new ProductSummary();
            prod.ProductId = 7;
            prod.Sku = "0007-unit";
            prod.Code = "0007";
            prod.Name = "Underworld DVD";
            prod.ShortDescription = "Underworld DVD Zone 4";
            prod.Manufacturer = "Lakeshore Entertainment ";
            prod.LowestPrice = 12;
            prod.UnitPrice = 15;
            products.Add(prod);

            prod = new ProductSummary();
            prod.ProductId = 8;
            prod.Sku = "0008-unit";
            prod.Code = "0008";
            prod.Name = "Underworld: Evolution DVD";
            prod.ShortDescription = "Underworld: Evolution DVD Zone 4";
            prod.Manufacturer = "Lakeshore Entertainment";
            prod.LowestPrice = 15;
            prod.UnitPrice = 18;
            products.Add(prod);
            return products;
        }
    }
}
