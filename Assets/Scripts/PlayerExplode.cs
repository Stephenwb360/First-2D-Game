using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExplode : MonoBehaviour
{

    [SerializeField] private GameObject Player;

    private bool isTouchingObjective = false;
    private bool timerStarted = false;

    [SerializeField] private SpriteRenderer picture;

    

    //private Collider objective;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartExplosionTimer();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Objective")
            Debug.Log("BOOM!"); // temporary
    }

    private void StartExplosionTimer()
    {
        if (Input.GetKeyDown(KeyCode.F) && !timerStarted)
        {
            picture.enabled = true;
            timerStarted = true;
        }
        //make explosion + timer + other stuff idk
    }
}
