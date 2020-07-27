using System;
using System.Collections.Generic;
using System.Text;

namespace Shopi.Task.Model
{
    public class ImportProductsRequest
    {
        public List<Product> ProductList;
    }

    public class Product
    {
        public string IntegrationId { get; set; }
        public string BaseProductCode { get; set; }
        public string ColorVariantCode { get; set; }
        public string Sku { get; set; }
        public string StockAmount { get; set; }
        public string Ean { get; set; }
        public string TaxRate { get; set; }
        public string Size { get; set; }
        public string Title { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public string MainCategory { get; set; }
        public string FirstSellingVat { get; set; }
        public string LastSellingVat { get; set; }
        public string Color { get; set; }
        public string Image1Link { get; set; }
        public string Image2Link { get; set; }
        public string Image3Link { get; set; }
        public string Image4Link { get; set; }
        public string Image5Link { get; set; }
        public string WebCategory { get; set; }
        public string Store { get; set; }
        public string IsDeleted { get; set; }
        public string IsUnpublished { get; set; }

        public string Variant3 { get; set; }
        public string Variant4 { get; set; }
        public string Filter3 { get; set; }
        public string Filter4 { get; set; }
        public string Filter5 { get; set; }
        public string Filter6 { get; set; }
    }
}
