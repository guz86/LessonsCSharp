namespace LINQCODEBLOG
{
    class Product
    {
        public string Name { get; set; }
        public int Energy { get; set; }

        public override string ToString()
        {
            return ("Name:"+Name+ "\t" +"Energy:"+Energy);
        }
    }
}
