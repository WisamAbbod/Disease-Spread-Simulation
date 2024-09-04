using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Instructions : MonoBehaviour
{
    [SerializeField] public GameObject Panelz;
    [SerializeField] public GameObject ecks;
    [SerializeField] public GameObject button;
    [SerializeField] public GameObject exit;

    private void Awake()
    {
        Button botn2 = button.GetComponent<Button>();   //Initialises the button
        botn2.onClick.AddListener(OnClick);
        Button boot = ecks.GetComponent<Button>();
        boot.onClick.AddListener(OneClicks);
        Button bort = exit.GetComponent<Button>();
        bort.onClick.AddListener(OneClick2);
    }


    public void OnClick()
    {

        Panelz.SetActive(true);           //removes home screen
       




    }

    public void OneClicks()
    {
        Panelz.SetActive(false);
    }

    public void OneClick2()
    {
        Application.Quit();
    }

}
