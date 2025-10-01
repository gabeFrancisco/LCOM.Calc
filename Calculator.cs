namespace LCOM.Calc
{
    public static class Calculator
    {
        private static decimal AttributeSum = 0;
        public static void Calculate(ClassProps classProps)
        {
            foreach (var props in classProps.AttributesInMethods)
            {
                AttributeSum += classProps.Methods - props;
            }

            int denominator = classProps.Attributes * classProps.Methods;
            Console.WriteLine(AttributeSum);
            Console.WriteLine(denominator);
            decimal result = AttributeSum / denominator;

            Console.WriteLine($"\nValor da equação = {result}");
        }
    }
}