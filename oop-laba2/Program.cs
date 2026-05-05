using System;
using System.Text;

public class Lab2
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; 

        string inputText = "Зварив собі каву, дивлюсь у вікно на цей дощ і думаю: ну і де та весна ділась";
        int targetLength = 5; 
        string replacement = "бургер";

        try
        {
            string result = ReplaceWords(inputText, targetLength, replacement);
            
            Console.WriteLine("Оригінальний текст: " + inputText);
            Console.WriteLine($"Результат (заміна слів з {targetLength} літер): " + result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public static string ReplaceWords(string text, int targetLength, string replacement)
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("Текст не може бути порожнім.");
        }

        StringBuilder textBuffer = new StringBuilder(text);
        StringBuilder resultBuffer = new StringBuilder();
        StringBuilder currentWord = new StringBuilder();

        for (int i = 0; i < textBuffer.Length; i++)
        {
            char ch = textBuffer[i];

            if (char.IsLetterOrDigit(ch))
            {
                currentWord.Append(ch);
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    if (currentWord.Length == targetLength)
                    {
                        resultBuffer.Append(replacement);
                    }
                    else
                    {
                        resultBuffer.Append(currentWord);
                    }
                    currentWord.Clear();
                }
                resultBuffer.Append(ch);
            }
        }

        if (currentWord.Length > 0)
        {
            if (currentWord.Length == targetLength)
            {
                resultBuffer.Append(replacement);
            }
            else
            {
                resultBuffer.Append(currentWord);
            }
        }

        return resultBuffer.ToString();
    }
}