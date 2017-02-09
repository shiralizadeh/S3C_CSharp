using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_CSharp.Models
{
    public class Product
    {
        public Product()
        {

        }

        ~Product()
        {

        }

        public Product(string title, long count)
        {
            this.Title = title;
            this.Count = count;
            this.Buyers = new ProductBuyer[5];
            this.RegisterDate = DateTime.Now;
        }

        public string Title { get; set; }

        public long Count { get; set; } = 10;

        private byte _rate = 0;
        public byte Rate
        {
            get
            {
                return this._rate;
            }
            set
            {
                if (value <= 10)
                    this._rate = value;
            }
        }

        public bool IsInStock => Count > 0;

        public ProductBuyer[] Buyers { get; set; }

        public ProductBuyer this[string name]
        {
            get
            {
                foreach (var item in this.Buyers)
                {
                    if (item.Name == name)
                        return item;
                }

                return null;
            }
        }

        public DateTime RegisterDate { get; set; }

        public void SetTitle(string newTitle)
        {
            this.Title = newTitle;
        }

        public void AddCount(int count)
        {
            this.Count += count;
        }

        public void AddCount(long count) => this.Count += count;

        public void AddCount(long count, string title)
        {
            this.Count += count;
            this.Title = title;
        }
    }

}
