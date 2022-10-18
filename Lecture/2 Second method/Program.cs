// принимает, но не возвращает
/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");*/

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}
//Method21("Текст", 4); // Вывод "текст" 4 раза

Method21(count: 4, msg: "новый текст");  