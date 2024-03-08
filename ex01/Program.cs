/*Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, 
если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито 
одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)
*/


bool[] CalcThat(string[] arr){                              //      счетный метод 
    bool[] calcArr = new bool[arr.Length];                  // создаем счетный массив  
    for(int i = 0; i < arr.GetLength(0); i++){
        if( arr[i].Length <= 3) calcArr[i] = true;
    }    
    return calcArr;
}

string[] CutThat(bool[] elms,string[] arr){                 //      выдает искомый массив 
    int len = 0; 
    foreach(bool el in elms){                               // считаем длинну
        if( el ) {
            len++;
        }
    }
    string[] anses = new string[len];                       // создаем массив ответа 
    
    int i = 0;                                              // cч. длинный 
    int a = 0;                                              // сч. ответа

    foreach(string ans in arr){                             // записываем ответы в массив
        if( elms[i] ){   
            anses[a] =  arr[i];
            a++;
        }
        i++;                                       
    }
    return anses;
}                                                    

Console.Write("Введите элементы через пробел:");              // ввод
string str = Console.ReadLine()!;
string[] objs = str.Split().ToArray();

bool[] elms = CalcThat( objs );                               //  запуск первого метода 

string[] anses = CutThat( elms, objs );                       //  Запуск второго метода 

Console.WriteLine( string.Join(", ", anses ));                // вывод
