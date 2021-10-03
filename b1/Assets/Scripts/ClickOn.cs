using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{   

    
    public Material white;
    public Material black;

    public MeshRenderer rend;

    public bool currentSelected = false;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        Click();
    }

    public void Click() 
    {
        if (currentSelected == false) 
        {
            rend.material = white;
        }
        else 
        {
            rend.material = black;
            
        }
    }
    
}
