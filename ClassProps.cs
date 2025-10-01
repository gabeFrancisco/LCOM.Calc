namespace LCOM.Calc
{
    public class ClassProps
    {
        public int Attributes { get; private set; }
        public int Methods { get; private set; }
        public int[] AttributesInMethods = [];

        public ClassProps(int attributes, int methods, int[] attributesInMethods)
        {
            Attributes = attributes;
            Methods = methods;

            if (attributesInMethods.Length != attributes)
            {
                throw new IndexOutOfRangeException("The dictionary must be the same count of attributes!");
            }

            AttributesInMethods = attributesInMethods;
        }
    }
}