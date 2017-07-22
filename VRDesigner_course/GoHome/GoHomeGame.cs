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

public class GoHomeGame : MonoBehaviour {

    public Vector2 playerLocation;
    public Vector2 homeLocation;
    bool gameIsOver = false;
    // Use this for initialization
    void Start () 
    {
        print("Welcome to Go Home!");
        print("Try to find your way back.");

    } 
    
    // Update is called once per frame
    void Update () {
        if(!gameIsOver)
        {
			UpdateMovement(KeyCode.LeftArrow, new Vector2(-1.0f, 0));
			UpdateMovement(KeyCode.RightArrow, new Vector2(1.0f, 0));
			UpdateMovement(KeyCode.UpArrow, new Vector2(0, 1.0f));
			UpdateMovement(KeyCode.DownArrow, new Vector2(0, -1.0f));
        }

    }

    private void UpdateMovement(KeyCode kc, Vector2 movementVector) 
    {
        if (Input.GetKeyDown(kc))
        {
            playerLocation = playerLocation + movementVector;
            printDistanceToHome();
        }
        
    }

    private void printDistanceToHome()
    {
        Vector2 pathToHome = homeLocation - playerLocation;
        print("Distance to home: " + pathToHome.magnitude);
        if (playerLocation == homeLocation)
        {
            print("You're home!");
            gameIsOver = true;
        }
    }
}





/*      detecting movement in Update() before making code above DRY
 *      if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            location = location + new Vector2(-1.0f, 0);
            Vector2 pathToHome = homeLocation - location;
            print('Distance to home: ' + pathToHome.magnitude);
            if (location == homeLocation)
            {
                print("You're home!");
            }
            //print("Left key pressed");
            //print("Location: " + location);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            location = location + new Vector2(1.0f, 0);
            //print("Right key pressed");
            //print("Location: " + location);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            location = location + new Vector2(0, 1.0f);
            //print("Up arrow pressed");
            //print("Location: " + location);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            location = location + new Vector2(0, -1.0f);
            //print("Down arrow pressed");
            //print("Location: " + location);
        }
 * 
 */

