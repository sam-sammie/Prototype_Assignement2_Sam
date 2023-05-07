using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) 
        { 
            ToggleInventory();
        }
    }

    public void ToggleInventory()
    {
        if (!inventory.activeSelf)
        {
           inventory.SetActive(true);
        }
        else
        {
            inventory.SetActive(false);
        }
    }


}
