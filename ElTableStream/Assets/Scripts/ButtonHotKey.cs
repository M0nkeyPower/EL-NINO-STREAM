using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonHotKey : MonoBehaviour {


	public List<KeyCode> hotkeys;
	Button button;



	// Use this for initialization
	void Start () 
	{
		
		button = gameObject.GetComponent<Button> ();

	}
	


	void OnGUI()
	{
		Event e = Event.current;
		if (e.isKey && !Input.anyKey)
		{
			for(int i = 0; i < hotkeys.Count; i++)
			{
				if(e.keyCode == hotkeys[i])
				{
					button.onClick.Invoke ();
					break;
				}
			}
		}


	}
}
