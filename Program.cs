// имплементация массива
string[] arr = {"1234", "good", "bad", "newest", "old", "better", "russia"};

// метод вывода массива
string WriteArray(string[] arr){
    string result = string.Empty;        
    result = $"["+ result;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) result = result + $"\"{arr[i]}\", ";
        else result = result +$"\"{arr[i]}\"]";
    }

    return result;
}

// Создание нового массива
// правильно так, но раз без коллекций
//List<String> newList = new List<String>();
string[] newArr = new string[0];

// счетчик элемента нового массива
int k = 0;

// заполняем новый массив из строк, длина которых меньше либо равна 3 символам.
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length < 4){
        Array.Resize(ref newArr, newArr.Length + 1);
        newArr[k] = arr[i];
        k++;
    }
}

// вывод результата
System.Console.WriteLine($"{WriteArray(arr)} -> {WriteArray(newArr)}");