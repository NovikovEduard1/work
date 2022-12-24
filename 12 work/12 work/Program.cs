using System;
using System.Collections.Generic;

namespace _12_work
{
	class Program
	{
		static void Main(string[] args)
		{
			triangle();
		}

		static void triangle()
        {
			double a, b, c, d;
			bool t;
			Console.WriteLine("введите 1 сторону ");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("введите 2 сторону ");
			b = double.Parse(Console.ReadLine());
			Console.WriteLine("введите 3 сторону");
			c = double.Parse(Console.ReadLine());
            if (a+b>c && b+c>a)
            {
				 t = true;
            }
            else
            {
				 t = false;
            }
            if (t)
            {
				Console.WriteLine("существует");
            }
            else
            {
				Console.WriteLine("не существует ");
			}
		}

			
		static void math()
        {
			double a,b,c,d;
			Console.WriteLine("введите число ");
			a = double.Parse(Console.ReadLine());
			b = a * a;
			c = a * a * a;
			d = a * a * a * a;
			Console.WriteLine(b+ "  в квадрате");
			Console.WriteLine(c + "  куб");
			Console.WriteLine(d +  "  4 степень");
		}
		static void body()
        {
			double a,b,c,d;
			Console.WriteLine("введите вес ");
			b = double.Parse(Console.ReadLine());
			Console.WriteLine("введите рост ");
			a = double.Parse(Console.ReadLine());
			d = a * a;
			c = b / d;
			Console.WriteLine(c + "имт");
		}
		static void temp()
		{
			double b;
			Console.WriteLine("введите в фаренгейтах ");
			b = double.Parse(Console.ReadLine());
			b = (b - 32) / 1.8;
			Console.WriteLine(b);
		}
		static void Distrib()
		{
			int[] muarr = { 5, 25, 45, 654, 85, 4, 8, 2, 65, };

			List<int> a = new List<int>();
			List<int> b = new List<int>();
			for (int i = 0; i < muarr.Length; i++)
			{
				if (muarr[i] % 2 == 0)
				{
					a.Add(muarr[i]);

				}
				else
				{
					b.Add(muarr[i]);
				}
			}
			int c = 0;
			if (a.Count >= b.Count)
			{
				c = a.Count;
			}
			else
			{
				c = b.Count;
			}
			for (int d = 0; d < c; d++)
			{
				if (a.Count >= d + 1)
				{
					Console.WriteLine(a[d]);
				}
				if (b.Count >= d + 1)
				{
					Console.WriteLine(b[d]);
				}

			}
		}

		static int man(int a, int b)
		{
			int c = 0;
			for (int i = 0; i < a; i++)
			{
				c = c + b;

			}

			return c;

		}
		static void op()
		{
			int r1 = (101 + 0) / 3;
			double r2 = 3.0e-6 * 10000000.1;
			bool r3 = true && true;
			bool r4 = false && true;
			bool r5 = (false && false) || (true && true);
			bool r6 = (false || false) && (true && true);

			Console.WriteLine("(101 + 0) / 3)-> " + r1);
			Console.WriteLine("(3.0e-6 * 10000000.1)-> " + r2);
			Console.WriteLine("(true && true)-> " + r3);
			Console.WriteLine("(false && true)-> " + r4);
			Console.WriteLine("((false && false) || (true && true))-> " + r5);
			Console.WriteLine("(false || false) && (true && true)-> " + r6);
		}
		static void equalsVal()
		{
			double a, b, c, d;
			string s;
			Console.WriteLine("введите первое число");
			a = double.Parse(Console.ReadLine());
			Console.WriteLine("введите второе число");
			b = double.Parse(Console.ReadLine());
			Console.WriteLine("введите третье число");
			c = double.Parse(Console.ReadLine());
			Console.WriteLine("введите четвёртое число");
			d = double.Parse(Console.ReadLine());

			if (a == b)
			{
				Console.WriteLine("равны");
			}
			else
			{
				Console.WriteLine("не равны");
			}
			if (a == c)
			{
				Console.WriteLine("равны");
			}
			else
			{
				Console.WriteLine("не равны");
			}
			if (a == d)
			{
				Console.WriteLine("равны");
			}
			else
			{
				Console.WriteLine("не равны");

			}

		}
		static void FindMaxValue()
		{
			int[] muarr = { 5, 25, 45, 654, 85, 4, 8, 2, 65, };
			int a = muarr[0];
			for (int i = 1; i < muarr.Length; i++)
			{
				if (muarr[i] < a)
				{
					a = muarr[i];
				}
				Console.WriteLine(a);
				Console.ReadLine();
			}
			static void FindMinValue()
			{
				int[] muarr = { 5, 25, 45, 654, 85, 4, 8, 2, 65, };
				int a = muarr[0];
				for (int i = 1; i < muarr.Length; i++)
				{
					if (muarr[i] > a)
					{
						a = muarr[i];
					}
					Console.WriteLine(a);
					Console.ReadLine();
				}
			}
			static void FindMidValue()
			{
				int[] muarr = { 5, 25, 45, 654, 85, 4, 8, 2, 65, };
				int a = muarr[0];
				int summ = 0;
				for (int i = 1; i < muarr.Length; i++)
				{
					summ += muarr[i];

				}
				double mid = summ / muarr.Length;
				Console.WriteLine(mid);

				for (int i = 1; i < muarr.Length; i++)
				{
					if (mid < muarr[i])
					{
						Console.WriteLine(muarr[i]);
					}
				}

			}
		}
	}
}

