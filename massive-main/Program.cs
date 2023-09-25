// See https://aka.ms/new-console-template for more information


int a = 2;
int b = 5;
int c = 3;
int d = 4;
int y = 6;
int [][] arr2 = new int[2][];
int [] arr3 = new int [9];
int [] arr4 = new int [9];
int [] arr = new int [9];
int [] arr5 = new int [9];
int [] arr6 = new int [9];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = a * (i + 1);
    System.Console.Write(arr[i] + " "); 

}
 System.Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    arr3[i] = c * (i + 1);
    System.Console.Write(arr3[i] + " "); 
}
 System.Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    arr4[i] = d * (i +1);
    System.Console.Write(arr4[i] + " ");
}
System.Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    arr5[i] = b * (i + 1);
    System.Console.Write(arr5[i] + " ");
}
System.Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    arr6[i] = y * (i + 1);
    System.Console.Write(arr6[i] + " ");
}
System.Console.WriteLine();


 arr2[0] = arr;
 arr2[1] = arr3;
 arr2[2] = arr4;
 arr2[3] = arr5;
 arr2[4] = arr6;


