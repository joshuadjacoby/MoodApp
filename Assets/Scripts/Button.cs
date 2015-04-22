using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour {
    public GameObject mainImage;
    private int moodNumber;
    public Sprite[] moods;
    // Use this for initialization
	void Start () {
        moodNumber = int.Parse(this.name.Substring(1));
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void changeImage() {
        Debug.Log("IMAGE CHANGED, we are " + moodNumber);
        mainImage.GetComponent<Image>().sprite = moods[moodNumber];
    }

    
}
