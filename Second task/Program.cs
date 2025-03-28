internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Введите два целых числа через Enter, первое должно быть меньше второго");
		bool isParsedFirstNumber = int.TryParse(Console.ReadLine(), out int firstNumber);
		if (isParsedFirstNumber == true)
		{
			bool isParsedSecondNumber = int.TryParse(Console.ReadLine(), out int secondNumber);
			if (isParsedSecondNumber == true)
			{
				if (Math.Abs(firstNumber) > 20000 || Math.Abs(secondNumber) > 20000)
				{
					Console.WriteLine("Числа не входят в заданный диапазон");
				}
				else
				{
					Program.BodyTask(firstNumber, secondNumber);
				}
			}
			else
			{
				Console.WriteLine("Введено некорректное значение, задача завершена...");
			}

		}
		else
		{
			Console.WriteLine("Введено некорректное значение, задача завершена...");
		}
	}
	private static void BodyTask(int firstNumber, int secondNumber)
	{
		if (firstNumber > secondNumber)
		{
			Console.WriteLine("Первое число должно быть меньше второго");
		}
		else
		{
			int biggestNumber = 1;
			for (int i = firstNumber; i < secondNumber; i++)
			{
				if (i % 7 == 0)
					biggestNumber = i;
			}
			if (biggestNumber == 1) //хочется другой механизм, но пока так тоже работает
			{
				Console.WriteLine("NO");
			}
			else
			{
				Console.WriteLine("Результат " + biggestNumber);
			}
		}
	}
}