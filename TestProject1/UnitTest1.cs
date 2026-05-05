using System;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void ReplaceWords_ShouldReplaceWordsOfExactLength()
    {
        string input = "Зварив собі каву, дивлюсь у вікно на цей дощ і думаю: ну і де та весна ділась";
        int length = 5; 
        string replacement = "бургер";
        string expected = "Зварив собі каву, дивлюсь у бургер на цей дощ і бургер: ну і де та бургер ділась.";
        
        string actual = Lab2.ReplaceWords(input, length, replacement);
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReplaceWords_ShouldNotChangeWordsIfNoMatches()
    {
        
        string input = "Короткий текст без довгих слів";
        int length = 10; 
        string replacement = "бургер";
        string expected = "Короткий текст без довгих слів";
        
        string actual = Lab2.ReplaceWords(input, length, replacement);
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ReplaceWords_EmptyString_ShouldThrowException()
    {
        string input = "";
        int length = 5;
        string replacement = "бургер";
        
        Assert.Throws<ArgumentException>(() => Lab2.ReplaceWords(input, length, replacement));
    }
}