namespace LCOM.Calc
{
    public static class Calculator
    {
        private static decimal AttributeSum = 0;
        public static decimal Calculate(ClassProps classProps)
        {
            for (int i = 0; i < classProps.AttributesInMethods.Length; i++)
            {
                AttributeSum += classProps.Methods - classProps.AttributesInMethods[i];
            }

            int denominator = classProps.Attributes * classProps.Methods;
            decimal result = AttributeSum / denominator;

            return result;
        }
    }
}