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
        if(Input.GetKeyDown("f") && inShip == false){
            InShip();
        }

        if(Input.GetKeyDown("f") && inShip == true){
            OutShip();
        }
    }

    public void InShip(){
        inShip = true;
        ship.SetActive(true);
        player.SetActive(false);
    }

    public void OutShip(){
        inShip = false;
        ship.SetActive(false);
        player.SetActive(true);
    }

}
