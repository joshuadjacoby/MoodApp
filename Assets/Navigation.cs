using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playButtonClicked()
	{
		Application.LoadLevel ("Play");	
	}

	public void learnButtonClicked()
	{
		Application.LoadLevel ("Learn");
	}


}
