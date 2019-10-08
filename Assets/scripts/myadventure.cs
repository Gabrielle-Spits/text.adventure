using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using UnityEngine;


public class myadventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro,
        deel1,
        sk11,
        sk12,
        sk21,
        sk22
        
        
        
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

    void OnUserInput(string input)
    {
        if (currentState == States.start)  //start
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

        if (currentState == States.intro) // begin
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

        if (currentState == States.deel1) // keuze1 voor het begin
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
        }

        if (currentState == States.sk11) 
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

        if (currentState == States.sk12)
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
        
        if (currentState == States.sk21)
            if (input == "start")
            {
             StartIntro();
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
        currentState = States.intro;
        Terminal.ClearScreen();
        Terminal.WriteLine("het was een koude donkere nacht");
        Terminal.WriteLine("Type verder");
    }


    void Startdeel1()
    {
        currentState = States.deel1;
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
        currentState = States.sk11;
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
        currentState = States.sk12;
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
        currentState = States.sk21;
        Terminal.ClearScreen();
        Terminal.WriteLine("je heb gekozen voor weg gaan");
        Terminal.WriteLine("je rent weg, maar knalt tegen een boom");
        Terminal.WriteLine("");
        Terminal.WriteLine("Door de klap tegen de boom val je dood neer");
        Terminal.WriteLine("type start om opnieuw te beginnen");
    }

    void Startkeuze4()
    {
        currentState = States.sk22;
        Terminal.ClearScreen();
        Terminal.WriteLine("");
    }

}

    