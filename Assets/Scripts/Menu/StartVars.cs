using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartVars : MonoBehaviour
{
    [SerializeField] public GameObject Initializer;
    
    public string script2 = "SceneVars";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClick()
    {
        (Initializer.GetComponent(script2) as MonoBehaviour).enabled = true;   //runs the days on button click
    }
}
