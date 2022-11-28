// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");


//string number = Console.ReadLine();
//int n = int.Parse(number);


#region 1. hem 3e ve 7e bolunsun


//if (n % 3 == 0 && n % 7 == 0)
//{
//    Console.WriteLine("bolnur");
//}

//else
//{
//    Console.WriteLine("bolunmur");
//}


#endregion

#region 2. 100 ve 200 arasinda tek ededlerin sayini tapib consola cixarin (for loop)

//for  ( int n = 100; n <= 200; n++) { 
//    if (n % 2 == 0)
//    {
//        Console.WriteLine(n);
//    }
//}
#endregion

#region 3. Verilmish int arrayinin en boyuk reqemini tapin.

//int[] arr = { 4, 77, 12, 21, 8, 89, 121 };
//int enboyuk = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > enboyuk)
//        enboyuk = arr[i];
//}
//Console.WriteLine(enboyuk);

#endregion

#region 4. Verilmish int arrayinin en kichik reqemini tapin. int[] arr

//int[] arr = { 4, 77, 12, 21, 8, 89, 121 };
//int enkicik = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < enkicik)
//        en = arr[i];
//}
//Console.WriteLine(enkicik);

#endregion

#region 5. Consoldan eded daxil edin ve hemin ededin nece mertebeli oldugunu tapin. 

//int number = 0;

//int count = 0;

//number = Convert.ToInt32(Console.ReadLine());
//while (number > 0)
//{
//    number = number / 10;
//    count++;
//}
//Console.WriteLine("Number of digits is : " + count);
//Console.ReadLine();

#endregion

#region Methods

static void Show (int[]arr, int n)
{

    int[] arr1 = arr;
    arr1
    ////int n = 20;
    //int tap = arr[0];
    for (int i = 0; i == 20; i++)
    {
        if (arr[i] == n)
            n = arr[i];
    }
    Console.WriteLine("tapildi");

}
#endregion