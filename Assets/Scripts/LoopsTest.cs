using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//	for (var i = -5; i<=5; i++)
    //    {
    //        print(i);
    //    }

     //   for (var i = 10; i<=50; i++)
     //   {
     //       if ( i % 2 == 0)
     //       {
     //           print(i);
     //       }
     //   }

        for (var i=1; i<=100; i++)
        {
            if (i % 15 == 0)
            {
                print(i);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
