using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldpop : MonoBehaviour
{

    public string populate;
    public int populateInt;
    [SerializeField] public TMP_InputField field1;             //adding all the input fields
    [SerializeField] public TMP_InputField field2;
    [SerializeField] public TMP_InputField field3;
    [SerializeField] public TMP_InputField field4;
    [SerializeField] public TMP_InputField field5;
    public GameObject inputField;
    public GameObject outputField;


    // Start is called before the first frame update
    public void StoreWaleed(string s)
    {
        SceneVars sv = GetComponent<SceneVars>();          //storing all the user inputs then putting them in SceneVars
        string txt = field1.text;
        SceneVars.TotalBlobs = int.Parse(txt); 

        
        string txt2 = field2.text;
        SceneVars.InfectionProb = int.Parse(txt);
        
        string txt3 = field3.text;
        SceneVars.RecoveryPeriod = int.Parse(txt);

        string txt4 = field4.text;
        SceneVars.ImmunityPeriod = int.Parse(txt);

/*
        string txt5 = field5.text;
        SceneVars.PCInfected = int.Parse(txt);
*/
        //  populate = s;
        //  populateInt = int.Parse(populate);



    }

    

  

  
}
