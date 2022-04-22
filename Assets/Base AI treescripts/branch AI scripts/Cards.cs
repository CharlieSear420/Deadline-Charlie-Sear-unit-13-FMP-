using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cards : Cardsbase
{
    public float pLeechCounter = 0f;
    public float pLeechCounterTwo = 0f;
    public float pHellCounter = 0f;
    //public float pJabCounter = 0f;

    public float loopAmount = 0f;

    public bool runLoop = true;
    
    void Start()
    {
        
    }

    void Update()
    {
        PlayerCountDown();
        EnemyCountDown();
        BurnCount();
        DrawCard();
        PlayerTimeLeech();
        PlayerHellFire();

        playerTimeText.text = (playerTimer).ToString();
        enemyTimeText.text = (enemyTimer).ToString();


        if (Input.GetKeyDown(KeyCode.J))
        { 
                StartCoroutine(MultiSecondJab());
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            pHellCounter = 10f;
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            pLeechCounter = 30f;
            pLeechCounterTwo = 2f;
        }
    }

   
    
    
    public void PlayerTimeLeech()
    {


        if( pLeechCounter > 0 )
        {
            playerTimer += Time.deltaTime / 50f;
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

    public void PlayerHellFire()
    {
        if (pHellCounter > 0)
        {
            pHellCounter -= Time.deltaTime;

            burnerTimer -= Time.deltaTime * 5;
        }


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

    public void PlayerHourHandLance()
    {
        enemyTimer -= 5f;
    }

    public void PlayerHailMary()
    {
        
    }

    public void DoubleEdgedSword()
    {
        enemyTimer -= 7.5f;
        //wait
        
        playerTimer -= cardsInPlayersHand;
    }

    public IEnumerator MultiSecondJab()
    {
        while (runLoop)
        {
            if (loopAmount == 10)
            {
                runLoop = false;
                break;
            }
            else
            {
                enemyTimer -= 1.5f;
            }

            loopAmount++;

            yield return new WaitForSeconds(1);
        }


    }

}
