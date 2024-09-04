using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartButton : MonoBehaviour
{
    [SerializeField] public GameObject MainMenuUI;
    [SerializeField] public GameObject MainSimulationUI;
    [SerializeField] public GameObject button;
    public bool GameStart= false;
    private void Awake()
    {
        Button btn = button.GetComponent<Button>();   //Initialises the button
        btn.onClick.AddListener(OnClick);

    }


    public void OnClick()
    {
       
        MainMenuUI.SetActive(false);           //removes home screen
        MainSimulationUI.SetActive(true);      //starts simulation screen
        GameStart = true;

        

    }



}
