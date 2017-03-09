using System.Collections.Generic;
using System.Linq;

namespace S3C_CSharp.Utilities
{
    class LINQ
    {
        public void Test()
        {
            var list = new List<Product>() {
                new Product() {  Title = "عینک", Count = 1, Price = 1200 },
                new Product() {  Title = "مدادرنگی", Count = 2, Price = 1800 },
                new Product() {  Title = "عروسک باربی", Count = 3, Price = 2000 },
                new Product() {  Title = "خودکار", Count = 10, Price = 45000 },
                new Product() {  Title = "صندلی", Count = 11, Price = 10 },
                new Product() {  Title = "در", Count = 1, Price = 600 },
                new Product() {  Title = "لیوان", Count = 31, Price = 8000 },
                new Product() {  Title = "قند", Count = 42, Price = 9000 },
                new Product() {  Title = "گوشت", Count = 1, Price = 4500 },
                new Product() {  Title = "موبایل", Count = 0, Price = 0 },
            };

            //list.Where((a) => { return a.Price == 22; }).Aggregate(item => item.Count).Select(item => item.Key);
        }

        public bool alaaaaa(string str)
        {
            return str == "C#";
        }
    }

    public class Product
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public long Price { get; set; }
    }
}
