using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject uiTutorial,btnBack;
    public TMP_Text tutorial, next;
    bool isClose;
    public bool gameStart;

    // Start is called before the first frame update
    void Start()
    {
        isClose = false;
        gameStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        if (isClose)
        {
            uiTutorial.SetActive(false);
            gameStart = true;
        }
        else
        {
            tutorial.text = "Click close to play";
            isClose = true;
            next.text = "Close";
            btnBack.SetActive(true);
        }
    }
    public void Back()
    {
        tutorial.text = "Use WASD for movement";
        isClose = false;
        next.text = "Next";
        btnBack.SetActive(false);
    }
}
