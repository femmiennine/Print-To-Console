using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintToConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            int num = Convert.ToInt32("45"); // convert string to int
            Console.WriteLine(num + 6); // returns 51
            
            Console.Write("Enter a number: ");
            int num1 = Convert.toInt32( Console.ReadLine() ); // ReadLine always returns a string, so you need to convert it if using int
            Console.Write("Enter another number: ");
            int num2 = Convert.toInt32( Console.ReadLine() );
            
            Console.WriteLine(num1 + num2);
            
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble( Console.ReadLine() ); // ToDouble handles decimals
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDoouble( Console.ReadLine() );
            
            Console.WriteLine(num1 + num2);
            
            Console.ReadLine();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
