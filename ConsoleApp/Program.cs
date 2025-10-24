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

//funkcja wygenerowana na podstawie nagłówka funkcji
int Sum(float a, float b) //Tokenizacja: int, Sum, (, float, a, ,, float, b, )
{ 
 return (int)(a + b); 
}

//funkcja wygenerowana na podstawie komentarza
//substract two numbers
int Subtract(float a, float b) { 
 return (int)(a - b); 
}

//multiply two numbers
int Multiply(float a, float b) { 
 return (int)(a * b); 
}

//funkcja wygenerowana na podstawie komentarza i nagłówka funkcji
//divide two numbers
//add error handling for division by zero using Exception
int Divide(float a, float b) { 
 if(b ==0) {
 throw new DivideByZeroException("Division by zero is not allowed.");
 }
 return (int)(a / b);
}

Point3D CreatePoint3D(float[] tab) { 
 if(tab.Length <3) {
 throw new ArgumentException("Array must contain at least three elements.");
 }
 return new Point3D(tab[0], tab[1], tab[2]); 
}