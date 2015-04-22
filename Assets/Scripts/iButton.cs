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
        moods = new string[5]{"Happy", "Sad", "Angry", "Embarrassed", "Scared"};
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void changeImage() {
        Debug.Log("IMAGE CHANGED, we are " + moodNumber);
        mainText.GetComponent<Text>().text = moods[moodNumber];
    }

    
}
