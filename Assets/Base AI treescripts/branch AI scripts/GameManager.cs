using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{

//-------------------------------<<<Base ints/floats>>>-------------------------------
    
    public int cardsInPlayersHand = 3; //temp
    public float drawTimer = 5f;
    public int burnerCards = 25;
    public float burnerTimer = 3f;
    public float enemyBurnerTimer = 3f;
    public float playerTimer = 120f;
    public float enemyTimer = 120f;
    public int boardSpace = 5;
  
//-------------------------------<<<UI Text>>>-------------------------------

    public Text playerTimeText;
    public Text enemyTimeText;
    public Text burnerCardsText;
    public Text deckSizeText;
    public Text divertTimeText;

//-------------------------------<<<UI Game Objects>>>-------------------------------

    public GameObject victoryText;
    public GameObject failureText;
    public GameObject cardsButtons;
    
//-------------------------------<<<Code stuff>>>-------------------------------

    public PreGameDeckDraw pg;
    public static GameManager gm;

//-------------------------------<<<Card Floats (For timers)>>>-------------------------------

    public float pLeechCounter = 0f;
    public float pLeechCounterTwo = 0f;
    public float pHellCounter = 0f;
    //public float pJabCounter = 0f;
    public float tDiversion = 20f;

    public float loopAmount = 0f;

//-------------------------------<<<Bools>>>-------------------------------

    public bool runLoop = true;
    public bool tDivert = false;


//-------------------------------<<<Card Strings>>>-------------------------------


    public string angel = "Angel";
    public string defensiveMirror = "Defensive Mirror";
    public string doubleEdgedSword = "Double Edged Sword";
    public string frontlineDefense = "Front Line Defense";
    public string graveRobber = "Grave Robber";
    public string hailMary = "Hail Mary";
    public string hellFire = "Hell Fire";
    public string hourHandLance = "Hour Hand Lance";
    public string lastLeg = "Last Leg";
    public string multiSecondJab = "Multi-Second Jab";
    public string timeLeech = "Time Leech";
    public string timerDiversion = "Timer Diversion";


//-------------------------------<<<Deck stuff>>>-------------------------------

    // Player's deck
    string[] playerDeckArray = new string[64];
    List<string> playerDeck;

    //creates array
    string[] enemyDeckArray = new string[64];

    List<string> playerHand;

    public Transform playerDeckSpawnLocation;
    public Transform enemyDeckSpawnLocation;

    public int i;
    public int f;

//-------------------------------<<<Start>>>-------------------------------

    void Start()
    {
        

        gm = this;



        //pg.i= 100;
        //pg.Start();

       

        playerHand = new List<string>();
        playerDeck = new List<string>();

        GeneratePlayerDeck();



    }

//-------------------------------<<<Update>>>-------------------------------

    void Update()
    {
        PlayerCountDown();
        EnemyCountDown();
        BurnCount();
        DrawCard();
        
        PlayerTimeLeech();
        PlayerHellFire();
        TimerDiversion();

//-------------------------------<<<Float to UI text>>>-------------------------------

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

        if( divertTimeText != null )
        {
            divertTimeText.text = tDiversion.ToString();
        } 


        
    }

//-------------------------------<<<Timer display stuff>>>-------------------------------

public void DisplayTime(float timeToDisplay)
{

}

//-------------------------------<<<Base stuff>>>-------------------------------

    public void DrawCard()
    {
        string str;

        if (drawTimer > 0)
        {
            drawTimer -= Time.deltaTime;
        }

        if (drawTimer <= 0)
        {
            //draw card
            drawTimer = 5f;
            str = GetFirstPlayerCard();


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

//-------------------------------<<<Card stuff>>>-------------------------------

    public void PlayerLeechTimer()
    {
        if (burnerCards >= 5)
        {
            pLeechCounter = 30f;
            burnerCards -= 5;
        }
        
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



    public void PlayerHellFireTimer()
    {
        if (burnerCards >= 10)
        {
            pHellCounter = 10f;
            burnerCards -= 10;
        }
        
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

    public void GraveRobber()
    {

    }

    public void LastLeg()
    {
        // front line defense count +2, burner cards *2, board space +2 > -2
    }

    public void TimerDiversion()
    {
        

        if (tDivert == true)
        {
            tDiversion -= Time.deltaTime;
            playerTimer += Time.deltaTime;
            
            if (tDiversion <= 0)
            {
                tDiversion = 20f;
                tDivert = false;
            }
        }
 
    }

    public void TimerDiversionActivate()
    {
        if (burnerCards >= 3)
        {
            tDivert = true;
            burnerCards -= 3;
        }
        
    }

    public void FrontlineDefense()
    {
         
    }

    public void PlayerHailMary()
    {
        
    }

    public void PlayerHourHandLance()
    {
        if (burnerCards >= 3)
        {
            enemyTimer -= 5f;
            burnerCards -= 3;
        }
        
        //print ("Hour Hand Lance waas played");
    }

    public void DoubleEdgedSword()
    {
        if (burnerCards >= 3)
        {
            enemyTimer -= 7.5f;
            playerTimer -= cardsInPlayersHand;
            burnerCards -= 3;
        }
        
    }

    public IEnumerator MultiSecondJab()
    {
        for( int i=0; i<10; i++ )
        {
            enemyTimer -= 1.5f;
            yield return new WaitForSeconds(1);

        }



        print ("Multisecond Jab was played");

    }

    public void JabMulti()
    {
        if (burnerCards >= 15)
        {
            StartCoroutine(MultiSecondJab());
            burnerCards -= 15;
        }
        
    }

//-------------------------------<<<More Deck stuff>>>-------------------------------


    void GeneratePlayerDeck()
    {
        string newString = "empty";
        for( int i=0; i<64; i++ )
        {
            //newObject = Instantiate( angel, playerDeckSpawnLocation.position, Quaternion.identity );
            f = Random.Range(1, 12);

            print("random=" + f);


            if (f == 1)
            {
                newString = angel;
            }
            if (f == 2)
            {
                newString = defensiveMirror;
            }
            if (f == 3)
            {
                newString = doubleEdgedSword;
            }
            if (f == 4)
            {
                newString = frontlineDefense;
            }
            if (f == 5)
            {
                newString = graveRobber;
            }
            if (f == 6)
            {
                newString = hailMary;
            }
            if (f == 7)
            {
                newString = hellFire;
            }
            if (f == 8)
            {
                newString = hourHandLance;
            }
            if (f == 9)
            {
                newString = lastLeg;
            }
            if (f == 10)
            {
                newString = multiSecondJab;
            }
            if (f == 11)
            {
                newString = timeLeech;
            }
            if (f == 12)
            {
                newString = timerDiversion;
            }


            playerDeck.Add(newString);
        }
    }

    // draw first card from deck 
    string GetFirstPlayerCard()
    {
        


        string firstCard = playerDeck[0];

        
        playerDeck.RemoveAt(0);
        return firstCard;
    }

    // store card in playerHand list
    void StorePlayerCard( string card )
    {
        playerHand.Add( card );

    }



}
