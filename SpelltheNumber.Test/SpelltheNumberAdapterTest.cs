using SpelltheNumberAdapter;
using System;
using Xunit;

namespace SpelltheNumber.Test
{
    public class SpelltheNumberAdapterTest
    {
        [Fact]
        public void CONVERTING_NUMBER_TO_WORDS()
        {
            // Arrange  
            var num = "12345";
            var expectedValue = "Twelve Thousand Three Hundred Fourty Five";
            // Act  
            NumberToWords numberToWord = new NumberToWords();
            var sum = numberToWord.changeNumericToWords(num);

            //Assert  
            Assert.Equal(expectedValue, sum);
        }
    }
}
