namespace S3C_CSharp.Classees
{
    class Product
    {
        public int MyCount = 10;

        public int AddCount(int count)
        {
            MyCount = MyCount + count;

            return MyCount;
        }
    }
}
