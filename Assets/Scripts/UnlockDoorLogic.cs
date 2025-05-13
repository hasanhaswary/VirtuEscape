using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoorLogic : MonoBehaviour
{
    bool puzzleOne = false;
    bool puzzleTwo = false;
    bool puzzleThree = false;


    public bool UnlockDoorChecker()
    {
        if (puzzleOne && puzzleTwo && puzzleThree)
        {
            // Logic to unlock the door
            Debug.Log("Door Unlocked!");
            return true;
        }
        else
        {
            Debug.Log("Solve all puzzles to unlock the door.");
            return false;
        }
    }
}
