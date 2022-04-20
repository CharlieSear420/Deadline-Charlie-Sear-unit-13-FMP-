using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : Cardsbase
{
    public float pLeechCounter = 0f;
    public float pLeechCounterTwo = 0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        PlayerCountDown();
        BurnCount();
        DrawCard();
        PlayerTimeLeech();
        if (Input.GetKeyDown(KeyCode.E))
        {
            pLeechCounter = 5f;
            pLeechCounterTwo = 2f;
        }
    }

   
    
    
    public void PlayerTimeLeech()
    {


        if( pLeechCounter > 0 )
        {
            playerTimer += Time.deltaTime / 1f;
            enemyTimer -= Time.deltaTime * 2;

            pLeechCounter -= Time.deltaTime;
        }


        return;


        if (pLeechCounter > 0)
        {
            
            
            

            if (enemyTimer > 0)
            {
                enemyTimer -= Time.deltaTime * 2;
            }

            if (pLeechCounterTwo > 0)
            {
                pLeechCounterTwo -= Time.deltaTime;
                
            }
            else
            {
                pLeechCounterTwo = 2f;
            }

        }
    }

    public void GraveRobber()
    {

    }

    public void HellFire()
    {

    }

    public void Angel()
    {

    }

    public void DefensiveMirror()
    {

    }

    public void LastLeg()
    {

    }

    public void TimerDiversion()
    {

    }

    public void FrontlineDefense()
    {

    }

    public void HourHandLance()
    {

    }

    public void HailMary()
    {

    }

    public void DoubleEdgedSword()
    {

    }

    public void MultiSecondJab()
    {

    }
}
