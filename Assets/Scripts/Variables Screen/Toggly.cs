using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   
    public void OnToggle(bool tog)
    {
        if (tog)
        {
            SceneVars.PCMasks = 20;
        }
        if (tog == false)
        {
            SceneVars.PCMasks = 0;
        }
    }
}
