using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEditorInternal;
using UnityEngine;


public class myadventure : MonoBehaviour
{
    private enum States //de state soorten 
    {
        start,
        begin,
        uitleg,
        keuzes_deel1,
        keuze1_deel1,
        keuze2_deel1,
        keuze3_deel1,
        keuze4_deel1,
        deel2,
        deel2_keuze1,
        deel2_keuze2,
        d2__keuze1_vervolg_keuze,
        d2_k1_vervolg_keuze_1,
        d2_k1_vervolg_keuze_2,
        d2_k1_v_keuze_2_vervolg,
        d2_k1_v_k2_vevolg_keuze,
        d2_k1_v_k2_v_keuze1,
        d2_k1_v_k2_v_keuze2,
        d2_k1_v_k2_v_k2_vervolg_keuze,
        d2_k1_v_k2_v_k2_vervolg_keuze1,
        d2_k1_v_k2_v_k2_vervolg_keuze2,
        d2_k1_v_k2_v_k2_v_k1_vervolg_keuze,
        d2_k1_v_k2_v_k2_v_k1_vervolg_keuze1,
        d2_k1_v_k2_v_k2_v_k1_vervolg_keuze2,
        einde
        
       
        



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
        /*
         * hier krijg de keuze tussen start
         *en krijg je uitleg
         * ik heb bij alle keuzes verschillende if en else gebruikt
         *zodat je naar verschillende states gaat
         */
        if (currentState == States.start) //hiermee controleer je in welke state je zit
        {

            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "uitleg")
            {
                Startuitleg();
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }

        if (currentState == States.uitleg)
        {
            if (input == "start")
            {
                StartIntro();
            }
        }

        if (currentState == States.begin) // begin hier start het begin
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

        if (currentState == States.keuzes_deel1) // hier komt de eerste keuze met if en if else dat je naar twee verschiilende states kunt gaan
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

        if (currentState == States.keuze1_deel1) //dood 1 hier krijg je je eerste dood en kan je terug naar start
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

        if (currentState == States.keuze3_deel1) //dood hier ga je terug naar start
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

        if (currentState == States.keuze4_deel1) //keuze 4
        {
            if (input == "verder")
            {
                Startdeel2();
            }

        }

        if (currentState == States.deel2) //hieer krijg je weer een keuze om deel 2 te starten
        {
            if (input == "onderdak")
            {
                Startdeel2_keuze1();
            }
            
            else if (input == "mes")
            {
                Startdeel2_keuze2();
            }
                
        }

        if (currentState == States.deel2_keuze2) 
        {
            if (input == "start")
            {
                StartIntro();
            }
            
        }

        if (currentState == States.deel2_keuze1) // na eten mee verder
        {
            if (input == "verder")
            {
                Startd2_keuze1_vervolg_keuze();
            }
        }

        if (currentState == States.d2__keuze1_vervolg_keuze) //dit is de vervolg keuze hiermee kun je verdr
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
        
        if (currentState == States.d2_k1_vervolg_keuze_1) //weer een keuze dood dus terug naar start
        {
            if (input == "start")
            {
                StartIntro();
            }
        }

        if (currentState == States.d2_k1_vervolg_keuze_2) //hier kun je weer verder
        {
            if (input == "verder")
            {
                Startd2_k1_v_keuze_2_vervolg();
            }
        }

        if (currentState == States.d2_k1_v_keuze_2_vervolg) //hiermee moet je weer verder
        {
            if (input == "verder")
            {
                Startd2_k1_v_k2_vevolg_keuze();
            }
        }

        if (currentState == States.d2_k1_v_k2_vevolg_keuze) //weer een keuze
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

        if (currentState == States.d2_k1_v_k2_v_keuze1) //dood terug naar start
        {
            if (input == "start")
            {
                StartIntro();
            }
            
        }
        
        if (currentState == States.d2_k1_v_k2_v_keuze2) //verder
        {
            {
                if (input == "verder")
                {
                    Startd2_k1_v_k2_v_k2_vervolg_keuze();
                }
            }
        }

        if (currentState == States.d2_k1_v_k2_v_k2_vervolg_keuze) //vervolg keuze
        {
            {
                if (input == "kijken")
                {
                    Startd2_k1_v_k2_v_k2_vervolg_keuze1();
                }
                
                else if (input == "niet")
                {
                    Startd2_k1_v_k2_v_k2_vervolg_keuze2();
                }
            }
        }

        if (currentState == States.d2_k1_v_k2_v_k2_vervolg_keuze2) // weer een dood terug naar start 
        {
            if (input == "start")
            {
                StartIntro();
            }
                
        }
        if (currentState == States.d2_k1_v_k2_v_k2_vervolg_keuze1) // bij de volgende kun je kieze uit de keuzes
        {
            {
                if (input == "keuze")
                {
                    Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze();
                }
            }
        }

        
        if (currentState == States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze) //hier krijg je die keuzes
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

        if (currentState == States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze1) //dood
        {
            {
                if (input == "opnieuw")
                {
                    StartIntro();
                }
            }
                
        }

        if (currentState == States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze2) // verder met keuze
        {
            {
                if (input == "verder")
                {
                    Starteinde();
                }
            }
        }

        if (currentState == States.einde) //einde terug naar einde
        {
            {
                if (input == "start")
                {
                    ShowMainmenu();
                }
                
            }
            
        }
        
        
    }

    void ShowMainmenu()     //hier zie je het menu
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("welkom bij mijn game");
        Terminal.WriteLine("het gaat over een dorpsgek");
        Terminal.WriteLine("type start om te beginnen");
        Terminal.WriteLine("type uitleg voor uitleg");


    }

    void Startuitleg()
    {
        currentState = States.uitleg; // dit is voor de uitleg
        Terminal.ClearScreen();
        Terminal.WriteLine("je wordt continu aangevallen door de dorpsgek");
        Terminal.WriteLine("het is de bedoeling dat je de goede ");
        Terminal.WriteLine("keuzes maakt zodat jij hem kunt doden");
        Terminal.WriteLine("type start om te beginnen");
    }
    void StartIntro()    //start begin
    {
        currentState = States.begin;
        Terminal.ClearScreen();
        Terminal.WriteLine("het was een koude donkere nacht");
        Terminal.WriteLine("Type verder");
    }


    void Startdeel1()  //start keuzez
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

    void Startkeuze1()  //start keuze 1
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

    void Startkeuze2() //start keuze 2 plus keuze 3
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

    void Startkeuze3() // keuze 3 optie 1
    {
        currentState = States.keuze3_deel1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je heb gekozen voor weg gaan");
        Terminal.WriteLine("je rent weg, maar knalt tegen een boom");
        Terminal.WriteLine("");
        Terminal.WriteLine("Door de klap tegen de boom val je dood neer");
        Terminal.WriteLine("type start om opnieuw te beginnen");
    }

    void Startkeuze4() //keuze 4 optie 2
    {
        currentState = States.keuze4_deel1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je heb gekozen voor staan");
        Terminal.WriteLine("");
        Terminal.WriteLine("type verder");


    }

    void Startdeel2() //start tweede deel game plus keuze
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

     void Startdeel2_keuze2() // keuze mes
     {
         currentState = States.deel2_keuze2;
         Terminal.ClearScreen();
         Terminal.WriteLine("je heb gekozen voor het mes");
         Terminal.WriteLine("je loopt verder");
         Terminal.WriteLine("je hoort geritsel");
         Terminal.WriteLine("de dorpsgek vermoord je");
         Terminal.WriteLine("type start om opnieuw te beginnen");
     }

     void Startd2_keuze1_vervolg_keuze() //vervolg keuze onderdak
     {
         currentState = States.d2__keuze1_vervolg_keuze;
         Terminal.ClearScreen();
         Terminal.WriteLine("je komt aan bij een oud houten huisje");
         Terminal.WriteLine("je vertrouwt het steeds minder");
         Terminal.WriteLine("als je wilt blijven type je blijven");
         Terminal.WriteLine("als je weg wilt type je weg");
     }

     void Startd2_k1_vervolg_keuze_1() //blijven + dood
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

     void Startd2_k1_v_keuze_2_vervolg() //vervolg
     {
         currentState = States.d2_k1_v_keuze_2_vervolg;
         Terminal.ClearScreen();
         Terminal.WriteLine("uiteindelijk kom je uit bij een boom");
         Terminal.WriteLine("je krijgt langzaam trek");
         Terminal.WriteLine("dus je gaat opzoek naar eten");
         Terminal.WriteLine("type verder");
     }

     void Startd2_k1_v_k2_vevolg_keuze() //vervolg keuze
     {
         currentState = States.d2_k1_v_k2_vevolg_keuze;
         Terminal.ClearScreen();
         Terminal.WriteLine("je vind een bos met besjes");
         Terminal.WriteLine("je krijgt nu een keuze");
         Terminal.WriteLine("als je de besjes wilt eten type je eten");
         Terminal.WriteLine("of als je verder wilt type dan zoeken");
     }

     void Startd2_k1_v_k2_v_keuze1() //vervolg keuze 1
     {
         currentState = States.d2_k1_v_k2_v_keuze1;
         Terminal.ClearScreen();
         Terminal.WriteLine("je heb gekozen om de besjes te eten");
         Terminal.WriteLine("");
         Terminal.WriteLine("helaas zijn ze giftig dus ga je dood");
         Terminal.WriteLine("type start om overnieuw te beginnen");
     }

     void Startd2_k1_v_k2_v_keuze2() //vervolg keuze 2
     {
         currentState = States.d2_k1_v_k2_v_keuze2;
         Terminal.ClearScreen();
         Terminal.WriteLine("je heb gekozen om verder te zoeken");
         Terminal.WriteLine("type verder");
     }

     void Startd2_k1_v_k2_v_k2_vervolg_keuze() //vervolg keuze
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

     void Startd2_k1_v_k2_v_k2_vervolg_keuze2() //niet +dood
     {
         currentState = States.d2_k1_v_k2_v_k2_vervolg_keuze2;
         Terminal.ClearScreen();
         Terminal.WriteLine("de dorpsgek slaat je neer");
         Terminal.WriteLine("type start om opnieuw te beginnen");
     }

    
     void Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze() // vervolg keuze
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

     void Startd2_k1_v_k2_v_k2_v_k1_vervolg_keuze2() //wapens
     {
         currentState = States.d2_k1_v_k2_v_k2_v_k1_vervolg_keuze2;
         Terminal.ClearScreen();
         Terminal.WriteLine("je kiest voor de wapens");
         Terminal.WriteLine("je leid dan wel honger");
         Terminal.WriteLine("maar jij wilt de dorpsgek doden");
         Terminal.WriteLine("Je ziet hem sluipt naar hem toe");
         Terminal.WriteLine("type verder");
     }

     void Starteinde() //einde +hoofdmeny
     {
         currentState = States.einde;
         Terminal.ClearScreen();
         Terminal.WriteLine("en steekt hem neer");
         Terminal.WriteLine("hij is dood dus jij heb gewonnen");
         Terminal.WriteLine("type start voor het menu ");
     }

}

    