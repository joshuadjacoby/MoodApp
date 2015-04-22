using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class iButton : MonoBehaviour {
    public GameObject mainText;
    private int moodNumber;
    private string[] moods;
    // Use this for initialization
	void Start () {
        moodNumber = int.Parse(this.name.Substring(1));
        moods = new string[10]{"Embarrassed", "Happy", "Sad", "Angry", "Confused", "Surprised", "Tired", "Annoyed", "Laughing", "Scared"};
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void changeImage() {
        mainText.GetComponent<Text>().text = moods[moodNumber];        
    }

    
}
