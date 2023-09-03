



#region Nesir Task1
//int[] arr = new int[100];
//int  size, number, location;
//Console.WriteLine("enter size of an array");
//size=Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter array elmement");
//for (int i = 0; i < size; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("enter elemnet for insert: ");
//number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine( "enter location: ");
//location = Convert.ToInt32(Console.ReadLine());
//for (int i=size;i>=location;i--)
//{
//    arr[i] = arr[i - 1];
//}
//size++;
//arr[location - 1] = number;
//Console.Write("List after Location: ");
//for (int i = 0;i < size; i++)
//{
//    Console.Write(arr[i] + " ");
//}
#endregion


#region Me Task1

//Console.WriteLine("Array sayi daxil edin:");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter elements of array");
//int[] arr = new int[a];
//for (int j = 0; j < a; j++)
//{
//    arr[j] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("Enter the index of element which you wanted to insert:");
//int index = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the element which you wanted to insert:");
//int num = Convert.ToInt32(Console.ReadLine());
//Array.Resize(ref arr, arr.Length + 1);

//for (int i = arr.Length-1; i >=index-1 ; i--)
//{
//    arr[i] = arr[i-1];
//}

//arr[index - 1] = num;

//foreach (int item in arr)
//{
//    Console.WriteLine(item);
//}


#endregion


#region Me Task5

//int[] arr = new int[10] {1,2,4,1,4,5,6,2,4,4};
//int count;
//for (int i = 0; i < arr.Length; i++)
//{
//    count = 1;
//    for (int j = 0; j<arr.Length; j++)
//    {
//        if (i != j && arr[i] == arr[j])
//        {
//            count++;
//        }
//    }
//    Console.WriteLine($"{arr[i]}-den {count} qederdir");
//}


#endregion


#region Me Task6

int[] arr = new int[10] { 1, 2, 3, 1, 3, 4, 5 , 2, 6, 2 };

int[] arr1 = new int[0];
bool isDub;
for (int i = 0; i < arr.Length; i++)
{
	isDub = false;
	for (int j = 0; j < arr.Length; j++)
	{
		if (i!=j && arr[i] == arr[j])
		{
			isDub = true;
			break;
		}

		
	}
	if (!isDub)
	{
		Array.Resize(ref arr1, arr1.Length + 1);
		arr1[arr1.Length - 1] = arr[i];
    }
}

foreach (int item in arr1)
{
	Console.WriteLine(item);
}
#endregion
