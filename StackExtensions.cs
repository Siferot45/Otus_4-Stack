
namespace OtusHomework_4
{
    // Доп. задание 1.
    public static class StackExtensions
    {
        public static void Merge(this CustomStack s1, CustomStack s2)
        {
            // Обратный порядок.
            s2.Stack.Reverse();
            // Слияние двух стеков.
            foreach (var item in s2.Stack)
            {
                s1.Add(item);
            }
        }
    }
}
