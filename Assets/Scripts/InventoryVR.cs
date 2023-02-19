// Script name: InventoryVR
// Script purpose: attaching a gameobject to a certain anchor and having the ability to enable and disable it.
// This script is a property of Realary, Inc

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryVR : MonoBehaviour
{
    public GameObject Inventory;
    public GameObject Inventory2;
    public GameObject Anchor;
    bool UIActive;
    bool UIActive2;
    private void Start()
    {
        Inventory.SetActive(false);
        UIActive = false;

        Inventory2.SetActive(false);
        UIActive2 = false;
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Four)&& !UIActive2)
        {
            UIActive = !UIActive;
            Inventory.SetActive(UIActive);
        }
        if (UIActive)
        {
            Inventory.transform.position = Anchor.transform.position;
            Inventory.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
        }


        if (OVRInput.GetDown(OVRInput.Button.Three) && !UIActive)
        {
            UIActive2 = !UIActive2;
            Inventory2.SetActive(UIActive2);
        }
        if (UIActive2)
        {
            Inventory2.transform.position = Anchor.transform.position;
            Inventory2.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
        }
    }
}

