// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] array = new int[]{1,2,5,0,10,34};
int num = array.Length - 1;

void ReverseArray(int[] array2, int index) 
{
    if(index < 0)
    {
        return;
    }
    Console.Write(array2[index]+ " ");
    ReverseArray(array2, index-1);  
}
ReverseArray(array, num);


