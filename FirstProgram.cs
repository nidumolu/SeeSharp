namespace SeeSharp;
using System;
//using System.Windows.Forms;
//namespace SeeSharp

class FirstProgram
{
    static void Main()
    {
        //MessageBox.Show("Hello, World!");
        Console.WriteLine("Is almost the same argument!");
    }
    private int _count;

    public int GetNextValue()
    {
        _count += 1;
        return _count;
    }
}