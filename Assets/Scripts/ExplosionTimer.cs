using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplosionTimer : MonoBehaviour
{
    [SerializeField] private Text timerText;

    [SerializeField] private GameObject bombMan;

    private PlayerExplode pExplode;

   
    void Awake()
    {
        pExplode = bombMan.GetComponent<PlayerExplode>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pExplode.timerStarted)
        {
            
            timerText.text = pExplode.timeRemaining.ToString("F2");
            if (pExplode.timeRemaining <= 0)
                timerText.text = "0.00";
        }
    }
}
