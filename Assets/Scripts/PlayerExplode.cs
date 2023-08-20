using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExplode : MonoBehaviour
{
    private bool exploded = false;
    private bool inExplosionRadius = false;
    public bool timerStarted = false;
    [SerializeField] public float timeRemaining = 3f;

    [SerializeField] private SpriteRenderer picture;

    


    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartExplosionTimer();
        checkExplosion();
    }//Update()

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.tag == "Objective")
           inExplosionRadius = true;
    }//TriggerEnter
    private void OnTriggerExit2D(Collider2D collider)
    {

        if (collider.tag == "Objective")
            inExplosionRadius = false;
    }//TriggerExit

    private void StartExplosionTimer()
    {
        if (Input.GetKeyDown(KeyCode.F) && !timerStarted)
        {
            picture.enabled = true;
            timerStarted = true;
        }
        if (timerStarted && timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);  //temporary  
        }
    }//StartExplosionTimer()

    void checkExplosion()
    {
        if(!exploded && timeRemaining <= 0 && inExplosionRadius)
        {
            Debug.Log("Boom!");
            exploded = true;
        }else if (!exploded && timeRemaining <= 0 && !inExplosionRadius)
        {
            Debug.Log("You Failed!!!");
            exploded = true;
        }
    }//checkExplosion()
}//PlayerExplode class
