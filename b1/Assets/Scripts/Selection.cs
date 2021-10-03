using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
public class Selection : MonoBehaviour {

    public LayerMask clickablesLayer;
    
    void Update()
    {
        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(myRay, out hit, Mathf.Infinity, clickablesLayer))
        {
            ClickOn clickOnScript = hit.collider.GetComponent<ClickOn>();
            clickOnScript.currentSelected = !clickOnScript.currentSelected;
            clickOnScript.Click();


        }

    }
}
