using ConsoleApp;

// Entry point and test method for WordSaver
void TestWordSaver()
{
    var wordSaver = new WordSaver();
    string textToSave = "This is a sample text saved to a Word document.";
    string filePath = "SampleDocument.docx";
    wordSaver.SaveStringToWord(textToSave, filePath);
    Console.WriteLine($"Word document saved to {filePath}");
}

TestWordSaver();

// Function generated based on function header
int Sum(float a, float b)
{
    return (int)(a + b);
}

// Function generated based on comment
// Subtract two numbers
int Subtract(float a, float b)
{
    return (int)(a - b);
}

// Multiply two numbers
int Multiply(float a, float b)
{
    return (int)(a * b);
}

// Function generated based on comment and function header
// Divide two numbers
// Add error handling for division by zero using Exception
int Divide(float a, float b)
{
    if (b == 0)
    {
        throw new DivideByZeroException("Division by zero is not allowed.");
    }
    return (int)(a / b);
}

Point3D CreatePoint3D(float[] tab)
{
    if (tab.Length < 3)
    {
        throw new ArgumentException("Array must contain at least three elements.");
    }
    return new Point3D(tab[0], tab[1], tab[2]);
}


// /optimize [...] using linq
/*IEnumerable<int> GetSquaresOfEven(IEnumerable<int> nums)
{
    var result = new List<int>();
    foreach (var num in nums)
    {
        if (num % 2 == 0)
        {
            result.Add(num * num);
        }
    }
    result.Sort();
    result.Reverse();
    return result;
}*/

IEnumerable<int> GetSquaresOfEven(IEnumerable<int> nums)
{
    return nums
        .Where(num => num % 2 == 0)
        .Select(num => num * num)
        .OrderByDescending(square => square)
        .ToList();
}


bool HasDuplicates(IEnumerable<int> nums)
{
    var seen = new HashSet<int>();
    foreach (var num in nums)
    {
        if (!seen.Add(num))
        {
            return true;
        }
    }
    return false;
}


float CalculateDiscount(float price, int percentage)
{
    if(percentage < 0 || percentage > 100)
            {
        throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100.");
    }
    return price + (price / percentage * 100);
}