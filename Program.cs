// See https://aka.ms/new-console-template for more information


int a = 2;
int b = 0;
int c = 3;
int [][] arr2 = new int[2][];
int [] arr3 = new int [9];
int [] arr = new int [9];
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

 arr2[0] = arr;
 arr2[1] = arr3;



