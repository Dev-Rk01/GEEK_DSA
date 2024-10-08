﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
	public static class SimpleProblems
	{
		public static int countDigit(int n)
		{
			if (n == 0) return 1;

			int count = 0;
			while (n > 0)
			{
				n = n / 10;
				count++;
			}
			return count;
		}

		public static string palindrome(int n)
		{
			if (n >= 0 && n < 10) return "Enter a two digit number";

			int rem = 0, rev = 0;
			int temp = n;

			while (temp > 0)
			{
				rem = temp % 10;
				temp = temp / 10;
				rev = rev * 10 + rem;
			}
			if (rev == n) return "Yes";
			return "No";
		}

		public static string fibonacci(int n)
		{
			if (n <= 0) return "Enter a valid number";
			int a = 0, b = 1, c = 0;
			string fibonacci = "" + a + " " + b;
			for (int i = 0; i < n; i++)
			{
				c = a + b;
				fibonacci = fibonacci + " " + c;
				a = b;
				b = c;
			}
			return fibonacci;
		}

		public static int factorial(int n)
		{
			if (n == 0) return 1;
			int fact = 1;
			while (n >= 1)
			{
				fact = fact * n;
				n--;
			}
			return fact;
		}

		public static int facorialByRecursion(int n)
		{
			if (n == 0) return 1;
			return n * facorialByRecursion(n - 1);
		}

		public static double countTrailingZerosInFactorial(int n)
		{
			
			double fact = 1;
			if (n == 0) fact = 1;
			double count = 0;
			while (n > 0)
			{
				fact = fact * n;
				n--;
			}

			while (fact % 10 == 0)
			{
				count++;
				fact = fact / 10;
			}
			return count;

		}


		public static int countTrailingZerosInFactorialOptimized(int n)
		{
			int temp = 1;
			int x = 1;
			int count = 0;
			while(temp>0)
			{
				temp = n / (int)Math.Pow(5, x);
				x++;
				count = count + temp;
			}
            return count;
		}
		public static int countTrailingZerosInFactorialOptimized_MethodTwo(int n)
		{
			int count = 0;
			for(int i=5; i<=n; i=i*5)
			{
                count = count +  n / i;
			}
            return count;
		}

		public static int hcfOfTwoNumbers(int a, int b)
		{
			int res = Math.Min(a, b);
			while (res > 0)
			{
				if (a % res == 0 && b % res == 0) break;
				res--;
			}
			return res;
		}
		
		public static int hcfOfTwoNumbersOptmized(int a, int b)
		{
			while(a!=b)
			{
				if (a > b) a = a - b;
				else b = b - a;
			}
			return a;
		}
		
		public static int hcfOfTwoNumbersFurtherOptmized(int a, int b)
		{
			if(b==0) return a;
			return hcfOfTwoNumbersFurtherOptmized(b, a % b);
		}

		public static int lcmOfTwoNumbers(int a, int b)
		{
			int max = Math.Max(a, b);
			while (true)
			{
				if (max % a == 0 && max % b == 0) return max;
				max++;
			}
		}
		
		public static int lcmOfTwoNumbersOptimized(int a, int b)
		{
			int HCF(int hcf_a, int hcf_b)
			{
				if (hcf_b == 0) return hcf_a;
				return HCF(hcf_b, hcf_a % hcf_b);
			}
			int hcf = HCF(a, b);

			return (a * b) / hcf;
		}

		public static bool isPrime(int n)
		{
			if (n == 0 || n == 1) return false;
			for(int i=2; i<n; i++)
			{
				if (n % i == 0) return false;
			}
			return true;
		}

		public static bool isPrimeOptimized(int n)
		{
			if (n == 0 || n == 1) return false;
			for(int i=2; i*i<n; i++)
			{
				if (n % i == 0) return false;
			}
			return true;
		}

		public static bool isPrimeFurtherOptimized(int n)
		{
			if (n == 0 || n == 1) return false;
			if (n == 2 || n == 3) return true;
			if (n % 2 == 0 || n % 3 == 0) return false;
			for (int i = 5; i * i < n; i = i + 6)
			{
				if (n % i == 0 || n % (i + 2) == 0) return false;
			}
			return true;
		}


		public static string primeFactor(int n)
		{
			List<int> primeFactors = new List<int>();
			for(int i=2; i*i<n; i++)
			{
				if(isPrimeFurtherOptimized(i))
				{
					int x = i;
					while(n%x==0)
					{
						primeFactors.Add(i);
						x = x * i;
					}
				}
			}
			return string.Join(", ", primeFactors);
		}

	}

}
