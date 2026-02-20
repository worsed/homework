using System;

class SortAlgorithms
{
    // Сортировка пузырьком
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Быстрая сортировка (Quick Sort)
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int pivot = arr[(left + right) / 2];
        int index = Partition(arr, left, right, pivot);

        QuickSort(arr, left, index - 1);
        QuickSort(arr, index, right);
    }

    private static int Partition(int[] arr, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (arr[left] < pivot) left++;
            while (arr[right] > pivot) right--;

            if (left <= right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
        }
        return left;
    }

    // Пример запуска
    static void Main()
    {
        int[] data = { 5, 2, 9, 1, 5, 6 };

        BubbleSort(data);
        Console.WriteLine("Bubble Sort: " + string.Join(", ", data));

        int[] data2 = { 3, 7, 4, 9, 5, 2 };
        QuickSort(data2, 0, data2.Length - 1);
        Console.WriteLine("Quick Sort: " + string.Join(", ", data2));
    }
}