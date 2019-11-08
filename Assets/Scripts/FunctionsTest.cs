using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print(isEven(4));
        print(isEven(3));
        print(whatIsBigger(-3, 5));
        print(whatIsBigger(10, 2));
        print(factorial(3));
        print(factorial(5));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    bool isEven(int num)
    {
        return (num % 2 == 0);
    }

    int whatIsBigger(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }

    void repeat(string msg, int count)
    {
        for (int i=0; i<count; i++)
        {
            print(msg);
        }
    }

    int factorial(int num)
    {
        int product = 1;
        for (int i=1; i<=num; i++)
        {
            product *= i;
        }
        return product;
    }
}
