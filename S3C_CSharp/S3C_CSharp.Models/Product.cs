using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3C_CSharp.Models
{
    public class Product : IDisposable, IConvertible, ICloneable
    {
        public Product()
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

        public void Dispose()
        {
            this.Title = null;

             // close connection
        }

        TypeCode IConvertible.GetTypeCode()
        {
            throw new NotImplementedException();
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return this.Count == 0 ? false : true;
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            var p = new Product();

            p.Title = this.Title;
            p.Count = this.Count;

            return p;
        }

        public override bool Equals(object obj)
        {
            var p = (Product)obj;

            return this.Title == p.Title && this.Count == p.Count;
        }

        public static long operator +(Product a, Product b)
        {
            return a.Count + b.Count;
        }

        //public static Product operator +(Product a, Product b)
        //{
        //    var newp = new Product();

        //    newp.Title = a.Title + b.Title;

        //    newp.Count = 1;

        //    return newp;
        //}

        public static Product operator +(Product a, int b)
        {
            a.Count += b;

            return a;
        }

        public static bool operator ==(Product a, Product b)
        {
            return a.Title == b.Title && a.Count == b.Count;
        }

        public static bool operator !=(Product a, Product b)
        {
            return !(a.Title == b.Title && a.Count == b.Count);
        }

        //public static explicit operator long(Product a)
        //{
        //    return a.Count;
        //}

        public static implicit operator long(Product a)
        {
            return a.Count;
        }

        //public static explicit operator ViewProduct(Product a)
        //{
        //    var v = new ViewProduct();

        //    v.Title = a.Title;
        //    v.Count = a.Count;

        //    return v;
        //}

        ~Product()
        {
            Dispose();
        }

    }

}
