namespace Anagrams.core
{
    public static class AnagramUtils
    {

        public static string BubbleSort(string word)
        {
            var letters = word.ToCharArray();
            int count = letters.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < count - 1; i++)
                {
                    if (letters[i] > letters[i + 1])
                    {
                        char c = letters[i];
                        letters[i] = letters[i + 1];
                        letters[i + 1] = c;
                        swapped = true;
                    }
                }
                count--;
            } while (swapped);

            string result = string.Join(", ", letters);
            return result;
        }
    }
}
