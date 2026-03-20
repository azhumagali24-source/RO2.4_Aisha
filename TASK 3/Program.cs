// Задача 1: Количество положительных чисел
int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

int result = 0;

foreach (int number in numbers)
{
    if (number > 0)
    {
        result++;
    }
}

Console.WriteLine($"Положительных чисел: {result}");


// Задача 2: Инверсия массива (переворот)
int[] arr = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

int n = arr.Length;
int k = n / 2;
int temp;

for (int i = 0; i < k; i++)
{
    temp = arr[i];
    arr[i] = arr[n - i - 1];
    arr[n - i - 1] = temp;
}

Console.WriteLine("Перевернутый массив:");
foreach (int i in arr)
{
    Console.Write(i + " ");
}


// Задача 3: Сортировка массива
int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };

for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}

Console.WriteLine("\nОтсортированный массив:");
foreach (int num in nums)
{
    Console.Write(num + " ");
} Console.WriteLine();