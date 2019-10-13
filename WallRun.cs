using UnityEngine;
using System.Collections;

public class WallRun : MonoBehaviour {

    gameObject player;

    // Use this for initialization
    void Start () {
        player = gameObject.find();
    }
    
    bool wallCheck () {
        Physics.Raycast(player.transform.position, player.transform.left, )
    }

    // Update is called once per frame
    void Update () {
    
    }
}