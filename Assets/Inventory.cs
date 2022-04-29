using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // check the slots is full or not
    // public bool[] isFull;
    public GameObject[] slot;
    public GameObject slotHolder;
    private  bool invertoryEnable;
    //private  bool invertoryDisable;
    public GameObject inventory;

    private int allslot;
    private int usedSlots;
    // Start is called before the first frame update
    void Start()
    {
        allslot = 40;
        slot = new GameObject[allslot];
        for (int i = 0; i < allslot; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) {
            invertoryEnable = !invertoryEnable;
        }
        if (invertoryEnable == true) {
            inventory.SetActive(true);
        }
        else {
            inventory.SetActive(false);
        }
    }
}
