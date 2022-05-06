using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreGameDeckDraw : MonoBehaviour
{
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
    GameObject[] playerDeckArray = new GameObject[64];
    List<GameObject> playerDeck;

    //creates array
    GameObject[] enemyDeckArray = new GameObject[64];

    List<GameObject> playerHand;

    public Transform playerDeckSpawnLocation;
    public Transform enemyDeckSpawnLocation;

    public int i;

    


    void Start()
    {

        //GeneratePlayerDeck();
        //GenerateEnemyDeck();

        //InstantiateDecks();

        Setup();
        GeneratePlayerDeck();


        GameObject card = GetFirstPlayerCard();
        StorePlayerCard( card );

    }

    void Setup()
    {
        playerHand = new List<GameObject>();
        playerDeck = new List<GameObject>();
    }

    void GeneratePlayerDeck()
    {
        GameObject newObject;
        for( int i=0; i<64; i++ )
        {
            newObject = Instantiate( angel, playerDeckSpawnLocation.position, Quaternion.identity );
            //turn angel to random card
            playerDeck.Add(newObject);
        }
    }

    // draw first card from deck 
    GameObject GetFirstPlayerCard()
    {
        GameObject firstCard = playerDeck[0];
        playerDeck.RemoveAt(0);
        return firstCard;
    }

    // store card in playerHand list
    void StorePlayerCard( GameObject card )
    {
        playerHand.Add( card );

    }

    /*


    void GeneratePlayerDeck()
    {


        


        int num;

        for (int i = 0; i < 64; i++)
        {
            num = Random.Range(0, 11); // check this gives a num between 0 and 11
            switch (num)
            {
                case 0:
                    playerDeckArray[i] = angel;
                    break;

                case 1:
                    playerDeckArray[i] = defensiveMirror;
                    break;

                case 2:
                    playerDeckArray[i] = doubleEdgedSword;
                    break;

                case 3:
                    playerDeckArray[i] = graveRobber;
                    break;

                case 4:
                    playerDeckArray[i] = hailMary;
                    break;

                case 5:
                    playerDeckArray[i] = hellFire;
                    break;

                case 6:
                    playerDeckArray[i] = hourHandLance;
                    break;

                case 7:
                    playerDeckArray[i] = lastLeg;
                    break;

                case 8:
                    playerDeckArray[i] = multiSecondJab;
                    break;

                case 9:
                    playerDeckArray[i] = timeLeech;
                    break;

                case 10:
                    playerDeckArray[i] = timerDiversion;
                    break;

                case 11:
                    playerDeckArray[i] = frontlineDefense;
                    break;

                

                default:
                    playerDeckArray[i] = hourHandLance;
                break;

            }
        }

        

    }


    void GenerateEnemyDeck()
    {

        int num;

        

        for (int i = 0; i < 64; i++)
        {
            num = Random.Range(0, 11); // check this gives a num between 0 and 11
            switch (num)
            {
                case 0:
                    enemyDeckArray[i] = angel;
                    break;

                case 1:
                    enemyDeckArray[i] = defensiveMirror;
                    break;

                case 2:
                    enemyDeckArray[i] = doubleEdgedSword;
                    break;

                case 3:
                    enemyDeckArray[i] = graveRobber;
                    break;

                case 4:
                    enemyDeckArray[i] = hailMary;
                    break;

                case 5:
                    enemyDeckArray[i] = hellFire;
                    break;

                case 6:
                    enemyDeckArray[i] = hourHandLance;
                    break;

                case 7:
                    enemyDeckArray[i] = lastLeg;
                    break;

                case 8:
                    enemyDeckArray[i] = multiSecondJab;
                    break;

                case 9:
                    enemyDeckArray[i] = timeLeech;
                    break;

                case 10:
                    enemyDeckArray[i] = timerDiversion;
                    break;

                case 11:
                    enemyDeckArray[i] = frontlineDefense;
                    break;



                default:
                    enemyDeckArray[i] = hourHandLance;
                    break;

            }
        }


    }

    void InstantiateDecks()
    {
        
        for (int i = 0; i < 64; i++)
        {
            Instantiate(playerDeckArray[UnityEngine.Random.Range(0, 11)], playerDeckSpawnLocation.position, playerDeckSpawnLocation.rotation);
            playerHand.Add(i);

            Instantiate(enemyDeckArray[UnityEngine.Random.Range(0, 11)], enemyDeckSpawnLocation.position, enemyDeckSpawnLocation.rotation);


        }


    }

    */
}
