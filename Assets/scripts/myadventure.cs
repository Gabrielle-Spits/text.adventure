using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEditorInternal;
using UnityEngine;


public class myadventure : MonoBehaviour
{
    private enum States
    {
        start,
        begin,
        keuzes_deel1,
        keuze1_deel1,
        keuze2_deel1,
        keuze3_deel1,
        keuze4_deel1,
        deel2,
        deel2_keuze1,
        d2__keuze1_vervolg_keuze,
        d2_k1_vervolg_keuze_1,
        d2_k1_vervolg_keuze_2,
        d2_k1_v_keuze_2_vervolg,
        d2_k1_v_k2_vevolg_keuze,
        d2_k1_v_k2_v_keuze1,
        d2_k1_v_k2_v_keuze2,
        d2_k1_v_k2_v_k2_vervolg_keuze,
        d2_k1_v_k2_v_k2_vervolg_keuze1,
        d2_k1_v_k2_v_k2_v_k1_vervolg_keuze,
        d2_k1_v_k2_v_k2_v_k1_vervolg_keuze1,
        d2_k1_v_k2_v_k2_v_k1_vervolg_keuze2
       
        



    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainmenu();
    }

    // Update is called once per frame

    void Update()
    {

    }

    void OnUserInput(string input) //startmenu
    {
        if (currentState == States.start) //start
        {

            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "welkom")
            {
                Terminal.WriteLine("cool");
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }

        if (currentState == States.begin) // begin
        {
            if (input == "Verder" || input == "verder" || input == "VERDER")
            {
                Startdeel1();
            }
            else if (input == "1212")
            {
                Terminal.WriteLine("verkeerde invoer");
            }
        }

        if (currentState == States.keuzes_deel1)
        {
            if (input == "Kijken")
            {
                Startkeuze1();
            }
            else if (input == "KIJKEN")
            {
                Startkeuze1();
            }

            else if (input == "kijken")
            {
                Startkeuze1();
            }

            else if (input == "Weglopen")
            {
                Startkeuze2();
            }

            else if (input == "WEGLOPEN")
            {
                Startkeuze2();

            }

            else if (input == "weglopen")
            {
                Startkeuze2();
            }
        }

        if (currentState == States.keuze1_deel1) //dood 1
        {
            if (input == "start")
            {
                StartIntro();
            }

            else if (input == "Start")
            {
                StartIntro();
            }

            else if (input == "START")
            {
                StartIntro();
            }
        }

        if (currentState == States.keuze2_deel1) //keuze 2
        {
            if (input == "weg")
            {
                Startkeuze3();
            }

            else if (input == "staan")
            {
                Startkeuze4();
            }
        }

        if (currentState == States.keuze3_deel1) //dood
        {
            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "Start")
            {
                StartIntro();
            }
            else if (input == "START")
            {
                StartIntro();
            }
        }

        if (currentState == States.keuze4_deel1)
        {
            if (input == "verder")
            {
                Startdeel2();
            }

        }

        if (currentState == States.deel2) // mee bezig
        {
            if (input == "onderdak")
            {
                Startdeel2_keuze1();
            }
        }

        if (currentState == States.deel2_keuze1)
        {
            if (input == "verder")
            {
                Startd2_keuze1_vervolg_keuze();
            }
        }

        if (currentState == States.d2__keuze1_vervolg_keuze)
        {
            if (input == "blijven")
            {
                Startd2_k1_vervolg_keuze_1();
            }
            else if (input == "weg")
            {
                Startd2_k1_vervolg_keuze_2();
            }
        }
        
        if (currentState == States.d2_k1_vervolg_keuze_1)
        {
            if (input == "start")
            {
                StartIntro();
            }
        }

        if (currentState == States.d2_k1_vervolg_keuze_2)
        {
            if (input == "verder")
            {
                Startd2_k1_v_keuze_2_vervolg();
            }
        }

        if (currentState == States.d2_k1_v_keuze_2_vervolg)
        {
            if (input == "verder")
            {
                Startd2_k1_v_k2_vevolg_keuze();
            }
        }

        if (currentState == States.d2_k1_v_k2_vevolg_keuze)
        {
            if (input == "eten")
            {
                Startd2_k1_v_k2_v_keuze1();
            }
            
            else if (input == "zoeken")
            {
                Startd2_k1_v_k2_v_keuze2();
            }
            
        }

        if (currentState == States.d2_k1_v_k2_v_keuze1)
        {
            if (input == "start")
            {
                StartIntro();
            }
            
        }
        
        if (currentState == States.d2_k1_v_k2_v_keuze2)
        {
            {
                if (input == "verder")
                {
                    Startd2_k1_v_k2_v_k2_vervolg_keuze();
                }
            }
        }

        if (currentState == States.d2_k1_v_k2_v_k2_vervolg_keuze)
        {
            {
                if (input == "kijken")
                {
                    Startd2_k1_v_k2_v_k2_vervolg_keuze1();
                }
            }
        }

        if (currentState == States.d2_k1_v_k2_v_k2_vervolg_keuze1)
        {
            {
                if (input == "keuze")
                {
                    Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze();
                }
            }
        }

        
        if (currentState == States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze)
        {
            {
                if (input == "eten")
                {
                    Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze1();
                }
                
                else if (input == "wapens")
                {
                    Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze2();
                }
            }
        }

        if (currentState == States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze1)
        {
            {
                if (input == "opnieuw")
                {
                    StartIntro();
                }
            }
                
        }
        
        
        
    }

    void ShowMainmenu()
    {
        Terminal.WriteLine("welkom bij smile");
        Terminal.WriteLine("hierbij maak je kennis met smiles");
        Terminal.WriteLine("type start om te beginnen");


    }

    void StartIntro()
    {
        currentState = States.begin;
        Terminal.ClearScreen();
        Terminal.WriteLine("het was een koude donkere nacht");
        Terminal.WriteLine("Type verder");
    }


    void Startdeel1()
    {
        currentState = States.keuzes_deel1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je loopt door een dorp");
        Terminal.WriteLine("je hoort een raar geluid");
        Terminal.WriteLine("Je heb nu je eersste keuze");
        Terminal.WriteLine("ga je kijken of loop je weg");
        Terminal.WriteLine("als je wilt kijken type je kijken");
        Terminal.WriteLine("als je weg wilt type je weglopen");

    }

    void Startkeuze1()
    {
        currentState = States.keuze1_deel1;
        Terminal.ClearScreen();
        Terminal.WriteLine("oke je heb gekozen voor kijken");
        Terminal.WriteLine("");
        Terminal.WriteLine("je loopt op het geluid af maar je ziet plots een bos");
        Terminal.WriteLine("je hoort geritsel en dan voel je een ");
        Terminal.WriteLine("klap met een knuppel tegen je hoofd");
        Terminal.WriteLine("Helaas je bent dood");
        Terminal.WriteLine("type start om opnieuw te beginnen");
    }

    void Startkeuze2()
    {
        currentState = States.keuze2_deel1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je heb gekozen voor weglopen");
        Terminal.WriteLine("");
        Terminal.WriteLine("je loopt verder door het dorp");
        Terminal.WriteLine("er is niemand om je heen");
        Terminal.WriteLine("je kijkt ziet een winkel je kijkt");
        Terminal.WriteLine("in het glas,je ziet iets");
        Terminal.WriteLine("je heb twee keuzes");
        Terminal.WriteLine("als je weg wilt type je weg");
        Terminal.WriteLine("als je wilt blijven staan type je staan");

    }

    void Startkeuze3()
    {
        currentState = States.keuze3_deel1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je heb gekozen voor weg gaan");
        Terminal.WriteLine("je rent weg, maar knalt tegen een boom");
        Terminal.WriteLine("");
        Terminal.WriteLine("Door de klap tegen de boom val je dood neer");
        Terminal.WriteLine("type start om opnieuw te beginnen");
    }

    void Startkeuze4()
    {
        currentState = States.keuze4_deel1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je heb gekozen voor staan");
        Terminal.WriteLine("");
        Terminal.WriteLine("type verder");


    }

    void Startdeel2()
    {
        currentState = States.deel2;
        Terminal.ClearScreen();
        Terminal.WriteLine("je voelt ineens een hand op je schouder");
        Terminal.WriteLine("je schrikt draait je om");
        Terminal.WriteLine("gelukkig het is iemand die in het dorp woont");
        Terminal.WriteLine("je heb 2 keuzes");
        Terminal.WriteLine("als je mee wilt type je onderdak");
        Terminal.WriteLine("als je het mes wilt type je mes");
    }

     void Startdeel2_keuze1()//keuze onderdak
    {
        currentState = States.deel2_keuze1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je heb gekozen voor onderdak");
        Terminal.WriteLine("");
        Terminal.WriteLine("je loopt mee met de man");
        Terminal.WriteLine("");
        Terminal.WriteLine("je bent bij het huisje aangekomen");
        Terminal.WriteLine("type verder");
    }

     void Startd2_keuze1_vervolg_keuze()
     {
         currentState = States.d2__keuze1_vervolg_keuze;
         Terminal.ClearScreen();
         Terminal.WriteLine("je komt aan bij een oud houten huisje");
         Terminal.WriteLine("je vertrouwt het steeds minder");
         Terminal.WriteLine("als je wilt blijven type je blijven");
         Terminal.WriteLine("als je weg wilt type je weg");
     }

     void Startd2_k1_vervolg_keuze_1() //blijven
     {
         currentState = States.d2_k1_vervolg_keuze_1;
         Terminal.ClearScreen();
         Terminal.WriteLine("je heb gekozen voor blijven");
         Terminal.WriteLine("");
         Terminal.WriteLine("helaas was de man een dorpsgek");
         Terminal.WriteLine("je bent met een knuppel neergeslagen");
         Terminal.WriteLine("type start om opnieuw te proberen");
     }

     void Startd2_k1_vervolg_keuze_2() //weg
     {
         currentState = States.d2_k1_vervolg_keuze_2;
         Terminal.ClearScreen();
         Terminal.WriteLine("je heb gekozen om weg te gaan");
         Terminal.WriteLine("");
         Terminal.WriteLine("De man roept je nog maar jij loopt door");
         Terminal.WriteLine("geen flauw idee waarheen");
         Terminal.WriteLine("maar jij blijft lopen");
         Terminal.WriteLine("wat een rare man was dat");
         Terminal.WriteLine("type verder");
     }

     void Startd2_k1_v_keuze_2_vervolg()
     {
         currentState = States.d2_k1_v_keuze_2_vervolg;
         Terminal.ClearScreen();
         Terminal.WriteLine("uiteindelijk kom je uit bij een boom");
         Terminal.WriteLine("je krijgt langzaam trek");
         Terminal.WriteLine("dus je gaat opzoek naar eten");
         Terminal.WriteLine("type verder");
     }

     void Startd2_k1_v_k2_vevolg_keuze()
     {
         currentState = States.d2_k1_v_k2_vevolg_keuze;
         Terminal.ClearScreen();
         Terminal.WriteLine("je vind een bos met besjes");
         Terminal.WriteLine("je krijgt nu een keuze");
         Terminal.WriteLine("als je de besjes wilt eten type je eten");
         Terminal.WriteLine("of als je verder wilt type dan zoeken");
     }

     void Startd2_k1_v_k2_v_keuze1()
     {
         currentState = States.d2_k1_v_k2_v_keuze1;
         Terminal.ClearScreen();
         Terminal.WriteLine("je heb gekozen om de besjes te eten");
         Terminal.WriteLine("");
         Terminal.WriteLine("helaas zijn ze giftig dus ga je dood");
         Terminal.WriteLine("type start om overnieuw te beginnen");
     }

     void Startd2_k1_v_k2_v_keuze2()
     {
         currentState = States.d2_k1_v_k2_v_keuze2;
         Terminal.ClearScreen();
         Terminal.WriteLine("je heb gekozen om verder te zoeken");
         Terminal.WriteLine("type verder");
     }

     void Startd2_k1_v_k2_v_k2_vervolg_keuze()
     {
         currentState = States.d2_k1_v_k2_v_k2_vervolg_keuze;
         Terminal.ClearScreen();
         Terminal.WriteLine("je zoekt verder");
         Terminal.WriteLine("je ziet iets liggen");
         Terminal.WriteLine("wil je kijken type dan kijken");
         Terminal.WriteLine("wil je niet kijken type dan niet");
     }

     void Startd2_k1_v_k2_v_k2_vervolg_keuze1() //kijken
     { 
         currentState = States.d2_k1_v_k2_v_k2_vervolg_keuze1;
         Terminal.ClearScreen();
         Terminal.WriteLine("Je heb gekozen om te kijken.");
         Terminal.WriteLine("type verder");
         Terminal.WriteLine("Je gaat kijken wat het is");
         Terminal.WriteLine("je ziet wapens en eten liggen");
         Terminal.WriteLine("je krijgt nu een keuze");
         Terminal.WriteLine("dus type keuze");
     }

    
     void Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze()
     {
         currentState = States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze;
         Terminal.ClearScreen();
         Terminal.WriteLine("je heb een tas");
         Terminal.WriteLine("maar daar past niet alles in");
         Terminal.WriteLine("ga je voor het eten en 1 wapen");
         Terminal.WriteLine("type dan eten");
         Terminal.WriteLine("of ben je vol gefocust om de");
         Terminal.WriteLine("dorpsgek te doden");
         Terminal.WriteLine("type dan wapens");
         
     }

     void Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze1() //eten
     {
         currentState = States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze1;
         Terminal.ClearScreen();
         Terminal.WriteLine("je kiest voor het eten en een wapen");
         Terminal.WriteLine("helaas staat de dorpsgek om de hoek");
         Terminal.WriteLine("hij steekt je neer");
         Terminal.WriteLine("type opnieuw om opnieuw te proberen");
     }

     void Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze2()
     {
         currentState = States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze2;
         Terminal.ClearScreen();
         Terminal.WriteLine("je kiest voor de wapens");
         Terminal.WriteLine("je leid dan wel honger");
         Terminal.WriteLine("maar je wilt de dorpsgek doden");
     }
}

    