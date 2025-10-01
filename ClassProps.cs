namespace LCOM.Calc
{
    public class ClassProps
    {
        private int _attributes;
        private int _methods;
        private Dictionary<int, int> _attributesInMethods = new Dictionary<int, int>();

        public ClassProps(int attributes, int methods, Dictionary<int, int> attributesInMethods)
        {
            _attributes = attributes;
            _methods = methods;

            if (attributesInMethods.Count != attributes)
            {
                throw new IndexOutOfRangeException("The dictionary must be the same count of attributes!");
            }

            _attributesInMethods = attributesInMethods;
        }


    }
}