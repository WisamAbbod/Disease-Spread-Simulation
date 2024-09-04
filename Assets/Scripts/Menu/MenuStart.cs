using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuStart : MonoBehaviour
{
    [SerializeField] public GameObject MainMenuUI;
    [SerializeField] public GameObject VariablesScreen;
    [SerializeField] public GameObject button;

    private void Awake()
    {
        Button botn = button.GetComponent<Button>();   //Initialises the button
        botn.onClick.AddListener(OnClick);

    }


    public void OnClick()
    {

        MainMenuUI.SetActive(false);           //removes home screen
        VariablesScreen.SetActive(true);      //starts simulation screen
       



    }



}
