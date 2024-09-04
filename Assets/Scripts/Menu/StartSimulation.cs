using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSimulation : MonoBehaviour
{
    [SerializeField]public GameObject Initialize;
    public string script = "InitPeople";
 

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
        (Initialize.GetComponent(script) as MonoBehaviour).enabled = true;   //starts the simulation on button click
        
    }
}
