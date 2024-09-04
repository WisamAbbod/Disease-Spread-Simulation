using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject Data;
    [SerializeField] public GameObject Results;
    [SerializeField] public GameObject Goals;
    [SerializeField] public GameObject Press;


    void Awake()
    {
        Button buttorn = Press.GetComponent<Button>();
        buttorn.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        Data.SetActive(true);
        Results.SetActive(true);
        Goals.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
