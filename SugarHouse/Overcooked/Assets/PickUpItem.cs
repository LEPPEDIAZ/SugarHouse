using UnityEngine;
using System.Collections;

public class PickUpItem : MonoBehaviour
{
    public GameObject player;

    //Invoked when a button is clicked.
    public void Example(Transform newParent)
    {
        //Sets "newParent" as the new parent of the player GameObject.
        player.transform.SetParent(newParent);

        //Same as above, except this makes the player keep its local orientation rather than its global orientation.
        player.transform.SetParent(newParent, false);
    }
}
