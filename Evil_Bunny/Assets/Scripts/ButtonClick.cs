using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ButtonClick : MonoBehaviour {

    public Bunny_Behavior bunny;
    public TimeDisplayer timer;

    GameObject button;


    Image image;
    Text text;

    // Use this for initialization
    void Start () {

        button = GameObject.Find("StartButton");
        if(text = GetComponent<Text>())
        {
            text = GetComponent<Text>();
        }
        if(image = GetComponent<Image>())
        {
            image = GetComponent<Image>();
        }


    }
	public void onClick()
    {
        button.SetActive(false);
        if (text = GetComponent<Text>())
        {
            text.text = "";
        }
        if (image = GetComponent<Image>())
        {
            image.enabled = false; 
        }
       
        timer.startgame();
        bunny.startgame();
        
        

    }
	// Update is called once per frame
	void Update () {
	
	}

 
}
