int[] CopyArr(int[] arr)
{
    int[] result = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }

    return result;
}

void Runner()
{
    int[] arr1 = CreateArray(len:5);
    PrintArray(arr1);

    int[] arr2 = arr1;
    PrintArray(arr2);

    arr1[0] = 422;
    PrintArray(arr1);
    PrintArray(arr2);

    int[] arr3 = CopyArr(arr1);
    arr1[1] = 1000;

    PrintArray(arr1);
    PrintArray(arr3);
}

Runner();

// код нужно дописывать!!!