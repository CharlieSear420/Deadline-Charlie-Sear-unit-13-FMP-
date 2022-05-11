using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{

    
    public int cardsInPlayersHand = 3;
    public float drawTimer = 5f;
    public int burnerCards = 25;
    public float burnerTimer = 3f;
    public float playerTimer = 120f;
    public float enemyTimer = 120f;
    public int boardSpace = 5;
    //public int playingDeck = 64;
    public Text playerTimeText;
    public Text enemyTimeText;
    public Text burnerCardsText;
    public Text deckSizeText;
    public GameObject victoryText;
    public GameObject failureText;
    public GameObject cardsButtons;
    public PreGameDeckDraw pg;
    public static GameManager gm;

    public float pLeechCounter = 0f;
    public float pLeechCounterTwo = 0f;
    public float pHellCounter = 0f;
    //public float pJabCounter = 0f;

    public float loopAmount = 0f;

    public bool runLoop = true;




    public GameObject angel;
    public GameObject defensiveMirror;
    public GameObject doubleEdgedSword;
    public GameObject frontlineDefense;
    public GameObject graveRobber;
    public GameObject hailMary;
    public GameObject hellFire;
    public GameObject hourHandLance;
    public GameObject lastLeg;
    public GameObject multiSecondJab;
    public GameObject timeLeech;
    public GameObject timerDiversion;


    // Player's deck
    string[] playerDeckArray = new string[64];
    List<string> playerDeck;

    //creates array
    string[] enemyDeckArray = new string[64];

    List<string> playerHand;

    public Transform playerDeckSpawnLocation;
    public Transform enemyDeckSpawnLocation;

    public int i;



    void Start()
    {
        //pg = gameObject.AddComponent<PreGameDeckDraw>();

        gm = this;



        //pg.i= 100;
        //pg.Start();

        print("game manager start");

        playerHand = new List<string>();
        playerDeck = new List<string>();



    }


    void Update()
    {
        PlayerCountDown();
        EnemyCountDown();
        BurnCount();
        DrawCard();
        PlayerTimeLeech();
        PlayerHellFire();
        //DoubleEdgedSword();


   

        if( playerTimeText != null )
        {
            playerTimeText.text = playerTimer.ToString();
        } 

        if( enemyTimeText != null )
        {
            enemyTimeText.text = enemyTimer.ToString();
        }
        
        if ( burnerCardsText != null )
        {
            burnerCardsText.text = burnerCards.ToString();
        }

        
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


    public void DrawCard()
    {
        if (drawTimer > 0)
        {
            drawTimer -= Time.deltaTime;
        }

        if (drawTimer <= 0)
        {
            //draw card
            drawTimer = 5f;
            string str = GetFirstPlayerCard();


        }
    }




    public void PlayerCountDown()
    {
        if (playerTimer > 0)
        {
            playerTimer -= Time.deltaTime;
        }

        if (enemyTimer <= 0)
        {
            Time.timeScale = 0f;
            victoryText.SetActive(true);
            cardsButtons.SetActive(false);
            print("VICTORY");
        }
    }

    public void EnemyCountDown()
    {
        if (enemyTimer > 0)
        {
            enemyTimer -= Time.deltaTime;
        }

        if (playerTimer <= 0)
        {
            Time.timeScale = 0f;
            failureText.SetActive(true);
            cardsButtons.SetActive(false);
            print("YOU LOOSE");
        }
    }

    public void BurnCount()
    {
        if (burnerTimer > 0)
        {
            burnerTimer -= Time.deltaTime;
        }

        if (burnerTimer <= 0)
        {
            burnerCards += 1;
            burnerTimer = 3f;
        }
    }


    public void PlayerLeechTimer()
    {
        pLeechCounter = 30f;
    }
    
    public void PlayerTimeLeech()
    {
        

        if( pLeechCounter > 0 )
        {
            playerTimer += Time.deltaTime / 50f;
            enemyTimer -= Time.deltaTime * 2;

            pLeechCounter -= Time.deltaTime;
            print ("Time Leech was played");
        }


        
    }

    public void GraveRobber()
    {

    }

    public void PlayerHellFireTimer()
    {
        pHellCounter = 10f;
    }

    public void PlayerHellFire()
    {
        
        if (pHellCounter > 0)
        {
            pHellCounter -= Time.deltaTime;

            burnerTimer -= Time.deltaTime * 5;
        }

       //print ("Hell Fire was played");

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
        print ("Hour Hand Lance waas played");
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

        print ("Multisecond Jab was played");

    }

    public void JabMulti()
    {
        StartCoroutine(MultiSecondJab());
    }

    void GeneratePlayerDeck()
    {
        string newString;
        for( int i=0; i<64; i++ )
        {
            //newObject = Instantiate( angel, playerDeckSpawnLocation.position, Quaternion.identity );
            //turn angel to random card
            playerDeck.Add(newString);
        }
    }

    // draw first card from deck 
    string GetFirstPlayerCard()
    {
        string firstCard = playerDeck[0];
        playerDeck.RemoveAt(0);
        //pla`
        return firstCard;
    }

    // store card in playerHand list
    void StorePlayerCard( string card )
    {
        playerHand.Add( card );

    }








}
