using Project498.WebApi.Services;

namespace Project498.WebApi.Tests;

public class StringServiceTests
{
    private readonly StringService _stringService = new();

    [Theory]
    [InlineData("hello", "olleh")]
    [InlineData("", "")]
    [InlineData(null, "")]
    [InlineData("a", "a")]
    [InlineData("racecar", "racecar")]
    [InlineData("hello world", "dlrow olleh")]
    [InlineData("hello  world", "dlrow  olleh")]
    [InlineData(" hello world", "dlrow olleh ")]
    [InlineData("hello world ", " dlrow olleh")]
    public void Reverse_WithVariousInputs_ReturnsExpectedResult(string? input, string expected)
    {
        var result = _stringService.Reverse(input!);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("hello world", "world hello")]
    [InlineData("apple banana", "banana apple")]
    [InlineData("one two three", "three two one")]
    [InlineData("single", "single")]
    [InlineData("", "")]
    [InlineData(null, "")]
    public void ReverseWord_WithVariousInputs_ReturnsExpectedResult(string? input, string expected)
    {
        var result = _stringService.ReverseWord(input!);

        Assert.Equal(expected, result);
    }
}
