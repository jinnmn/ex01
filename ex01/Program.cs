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
            anses[a] =  ans;
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
