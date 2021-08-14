public class ProdFib
{
    public static ulong[] productFib(ulong prod)
    {
        ulong num1 = 0; 
        ulong num2 = 1;

        while (true)
        {
            if (num1 * num2 == prod)
                return new ulong[] { num1, num2, 1};
            if(num1 * num2 > prod)
                return new ulong[] { num1, num2, 0};

            ulong num3 = num1 + num2; 
            num1 = num2; 
            num2 = num3; 
        }
    }
}