namespace Calculators
{
    public static class Calculadora
    {
        private static double a = 0, b = 0, res = 0;
        private static char op;

        public static double A
        {
            get { return a; }
            set { a = value; }
        }

        public static double B
        {
            get { return b; }
            set { b = value; }
        }

        public static double Res
        {
            get { return res; }
            set { res = value; }
        }

        public static char Op
        {
            get { return op; }
            set { op = value; }
        }

        public static string Calculate()
        {
            switch (op)
            {
                case '+':
                    res = a + b;
                    break;
                case '-':
                    res = a - b;
                    break;
                case '/' :
                    res = a / b;
                    break;
                case '*':
                    res = a * b;
                    break;
            }

            return a + "{op}" + b + "=" + res;
        }
    }
}