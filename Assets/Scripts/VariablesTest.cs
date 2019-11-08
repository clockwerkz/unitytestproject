using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesTest : MonoBehaviour {

    public string firstName;
    public string lastName;
    public int birthYear;


	// Use this for initialization
	void Start () {
        print("Your name is " + firstName + " " + lastName + ".");
        print("Your initials are " + firstName[0] + lastName[0] + ".");
        print("The character length of your full name is: " + (firstName + lastName).Length.ToString() + ".");
        print("Hello" + 5);
        print("A random character in your full name is: " + (firstName + lastName)[generateRandomNumber()].ToString() + ".");
        print("You were born in " + birthYear.ToString() + ", which means you are " + (2019 - birthYear).ToString() + " years old.");
        print("You have been alive for " + ((2019-birthYear)*365).ToString() +" days.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    int generateRandomNumber()
    {
        System.Random random = new System.Random();
        return random.Next((firstName + lastName).Length);
    }
}
