using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInShip : MonoBehaviour
{

    public GameObject ship;
    public GameObject player;

    private bool inShip = false;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown("f")){
            InShip();
        }
    }

    public void InShip(){
        print("getting in ship");
        inShip = true;
        ship.SetActive(true);
        player.SetActive(false);
    }

}
