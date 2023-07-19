
String[] arr1 = {"hello", "2", "world", ":-)", "1234", "computer science", "Russia", "-2"};
string[] arr2 = new string[arr1.Length];

void Process(string[] arr1, string[] arr2){
    int n = 0;
    for (int i = 0; i < arr1.Length; i++){
        if(arr1[i].Length <= 3){
          arr2[n] = arr1[i];
         n++;
        }
    }
    Array.Resize(ref arr2, n);
}

void PrintArray(string[] arr){
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr1);
Process(arr1, arr2);
PrintArray(arr2);
