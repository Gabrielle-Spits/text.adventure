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
        sk1,
        pad1
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
        if (currentState == States.start)
        {

            if (input == "start")
            {
                StartIntro();
            }
            else if (input == "1337")
            {
                Terminal.WriteLine("jij bent Leet!");
            }
            else
            {
                Terminal.WriteLine("Verkeerde invoer");
            }
        }

        if (currentState == States.intro)
        {
            if (input == "Verder" || input == "verder" || input == "VERDER")
            {
                Startdeel1();
            }
            else if (input == "1212")
            {
                Terminal.WriteLine("je gaat weg");
            }
        }
    }
        if (currentState == States.sk1)
    {
        if (input ==)
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
        Terminal.WriteLine("Een goede nacht om Fortnite te doen");
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
            
    }

    void Startsk1()
    {
        currentState = States.sk1;
        Terminal.ClearScreen();

    }
}

    