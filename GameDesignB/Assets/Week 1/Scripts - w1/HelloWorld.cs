using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

// Up here is where we tell the computer what tools we want to use while writing
// our code, all of them are automatic except for the last one, can you tell me
// why you think we have added the last one?

// This is where we make things happen, first we make sure the name here is the
// same as the one on our script se we don't get any errors

public class HelloWorld : MonoBehaviour
{
    //Here we are telling the computer that we want to make a new thing, that
    //uses the text component that we just made, we then called it "intro"
    public TextMeshProUGUI intro;

    // Start is called before the first frame update when you start the game
    void Start()
    {
        //Here we are telling the coputer what we want text to be, becasue we
        //made it public we can click and drag it in in the Unity Editor
        intro = GetComponent<TextMeshProUGUI>();

        intro.text = "Hello World";
    }

    // Update is called once per frame
    void Update()
    {
        //try changing this to introduce yourself to the class
        intro.text = "My Name Is Jamie, I am 23 Years Old And I Am From Dublin";

        //What about colour? What colour would you like our text to be?
        //Once you start typing your colour, for example "Blue" the computer
        //Should auto complete it for you!

        intro.color = Color.green;

        //We can get more specific with our colours but we cn look at that later
    }
}
