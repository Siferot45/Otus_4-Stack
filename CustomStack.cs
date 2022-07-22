using System;
using System.Collections.Generic;
using System.Linq;

namespace OtusHomework_4
{
    public class CustomStack
    {
        // Размер List.
        public int Size { get; private set; }
        // Верхний элемент List.
        public string Top { get; private set; }
        // Хранилеще List.
        public List<string> Stack { get; set; }
        public CustomStack(params string[] input)
        {
            
            Stack = new List<string>();
            Top = null;
            Size = 0;
            // Неограниченное количество входных параметров.
            {
                foreach (var item in input)
                {
                    Stack.Add(item);
                    Top = item;
                    Size++;
                }
            }
        }
        // Добавление по одному параметру.
        public void Add(string input)
        {
            Stack.Add(input);
            Top = input;
            Size++;
        }
        // Извлекает верхний элемент и удаляет его из стека.
        public string Pop()
        {
            // Проверка List на количество элементов.
            if (Stack.Count > 0)
            {
                var input = Stack.LastOrDefault();
                Stack.Remove(input);
                Top = Stack.LastOrDefault();
                Size--;
                return input;
            }
            // Выброс Exception если List пуст.
            else
            {
                throw new NullReferenceException("Стек пустой.");
            }
        }
    }
}
