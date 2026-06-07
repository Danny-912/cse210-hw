using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        
        
        // W03 Learning Activity: Encapsulation - Fraction Class
// Tests all three constructors, getters/setters, and representation methods
 
// --- Constructor 1: No parameters → 1/1 ---
Fraction f1 = new Fraction();
Console.WriteLine(f1.GetFractionString());  // 1/1
Console.WriteLine(f1.GetDecimalValue());    // 1
 
// --- Constructor 2: One parameter → 5/1 ---
Fraction f2 = new Fraction(5);
Console.WriteLine(f2.GetFractionString());  // 5/1
Console.WriteLine(f2.GetDecimalValue());    // 5
 
// --- Constructor 3: Two parameters → 3/4 ---
Fraction f3 = new Fraction(3, 4);
Console.WriteLine(f3.GetFractionString());  // 3/4
Console.WriteLine(f3.GetDecimalValue());    // 0.75
 
// --- Constructor 3: Two parameters → 1/3 ---
Fraction f4 = new Fraction(1, 3);
Console.WriteLine(f4.GetFractionString());  // 1/3
Console.WriteLine(f4.GetDecimalValue());    // 0.3333333333333333
 
// --- Testing Getters and Setters ---
Fraction f5 = new Fraction(2, 5);
Console.WriteLine($"\nBefore change: {f5.GetFractionString()}");  // 2/5
 
f5.SetTop(7);
f5.SetBottom(8);
Console.WriteLine($"After change:  {f5.GetFractionString()}");    // 7/8
Console.WriteLine($"Top: {f5.GetTop()}, Bottom: {f5.GetBottom()}"); // Top: 7, Bottom: 8
    }
}
    
