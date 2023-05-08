using System;

namespace ConsoleAppCshap
{
    class Program
    {
        /*
         1.Tinh tong so nguyen tu 1 den n (n la dau vao) va hien thi ra man hinh
         2. Tinh tong cac so theo day so sau: 1 + 1/3 +1/5 +1/7 +...+ 1/2n+1
        */
        static void Main(string[] args)
        {
            int n = 10, m = 100;
            Console.WriteLine("Tong hai so m va n la:" + Add(n, m));
            Console.WriteLine("Gia tri nho nhat trong 2 so la:" + Min(n, m, k));

            double d = 1 / 2;
            Console.WriteLine();

            Console.WriteLine(newstring('=', 50));
            //Input value from keyboard
            Console.Write("Nhap tham so a=");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap tham so b=");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap tham so c=");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            GiaiPhuongTrinhBacHai(a, b, c);

            Console.Write("Nhap vao so u=");
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            TongCacSoNguyenN(u);

            Console.ReadLine();
        }
        /* */

        public static int Add(int a, int b)
        {
            int total = a + b;
            return total;
        }
        /*find min value*/
        public static int Min(int a, int b)
        {
            return a > b ? b : a; //conditional expression
        }
        public static int Min(int a, int b, int c)
        {
            return Min(Min(a, b), c);
        }
        public static int Max(int a, int b) => a > b ? a : b;

        /*giai pt bac 2*/
        public static void GiaiPhuongTrinhBacHai(int a, int b, int c)
        {
            int deltal = 0;
            double x1, x2;
            if (a == 0 && b != 0)
            {
                Console.WriteLine("Phuong trinh co nghiem don x=" + (-c / b));
            }
            else
            {
                deltal = (int)Math.Pow(b, 2) - 4 * a * c;
                if (deltal > 0)
                {
                    x1 = -b + Math.Sqrt(deltal) / (2 * a);
                    x2 = b + Math.Sqrt(deltal) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet x1 =" + x1
                        + "x2=" + x2);
                } else if (deltal == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep x1=x2=" + (Convert.ToDouble(-b / (2 * a)));
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }

        }
        /*tong cac so nguyen*/
        public static void TongCacSoNguyenN(int u)
        {
            int sum = 0;
            for (int i=1; i<=u;i+=1)
            {
                sum =+ i;
            }
            return sum;
            Console.WriteLine("Tong cac so tu 1 den u la:" + Sum);
        }
        //đệ qui
        int F(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return n * F(n - 1);
        }
    }
}
 
