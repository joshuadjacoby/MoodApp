using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Button : MonoBehaviour {
    public GameObject mainImage;
    private int moodNumber;
    private Sprite[] moods;
    private Button[] buttons;
    // Use this for initialization
	void Start () {
        moodNumber = int.Parse(this.name.Substring(1));
        moods = Resources.LoadAll<Sprite>("Sprites");

	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void changeImage() {
        mainImage.GetComponent<Image>().sprite = moods[moodNumber];
    }

    
}
