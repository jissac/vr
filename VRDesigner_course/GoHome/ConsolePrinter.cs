/* Intro to the Unity console and to C#
 * Pseudo Code:
 * -Set start location
 * -Calculate distance from home
 * -Print distance from home
 * -Read player's move
 * -Update location from home
 * -Repeat
 */

using UnityEngine;
using System.Collections;

public class ConsolePrinter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("Welcome to Go Home!");
		print("Try to find your way back.");

        float location = 5.0f; // Distance in meters
        float homeLocation = 2.1f;
        float distance = homeLocation - location;
        print("Distance:" + distance);

        if (location > homeLocation)
        {
            print("Go backward to get home");
        }
        else if (location < homeLocation)
        {
            print("Go forward to get home");
        }
        else if (location == homeLocation)
        {
            print("You're home!");
        }

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Left key pressed");
        }
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			print("Right key pressed");
		}
    }
}
