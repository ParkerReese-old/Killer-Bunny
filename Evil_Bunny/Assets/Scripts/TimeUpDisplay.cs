using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeUpDisplay : MonoBehaviour {

    public Bunny_Behavior bunny;
    public TimeDisplayer timer;

    Text text;

    // Use this for initialization
    void Start () {

        text = GetComponent<Text>();

        text.text = "";

    }
	

   public void Wait() 
    {
      if(SceneManager.GetActiveScene().name == "scene2")
        {
            Application.LoadLevel("Scene1Done");
        }
      if(SceneManager.GetActiveScene().name == "Scene1Done")
        {
            Application.LoadLevel("Scene2Done");
        }
      
      if(SceneManager.GetActiveScene().name == "Scene2Done")
        {
            Application.LoadLevel("Scene3Done");
        }
      if (SceneManager.GetActiveScene().name == "Scene3Done")
        {
            Application.LoadLevel("scene2");
        }


    }

    public void TimeUp()
    {
        text.text = "Time Up!";

        timer.endgame();
        bunny.endgame();

        Invoke("Wait", 3);

        
    }
}
