using UnityEngine;
using System.Collections;

public class WallRun : MonoBehaviour {

    gameObject player;

    // Use this for initialization
    void Start () {
        player = gameObject.find();
    }
    
    // Returns 0 if no walls, or 1-4 for which direction a wall is going clockwise from forward.
    int wallCheck () {
        Physics.Raycast(player.transform.position, player.transform.left);
    }

    // Update is called once per frame
    void Update () {
    
    }
}