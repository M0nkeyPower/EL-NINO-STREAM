using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldControll : MonoBehaviour {

	 InputField fieldText;

	void Start()
	{
		fieldText = gameObject.GetComponent<InputField> ();
	}

	public void addPoint()
	{
		int currentValue = int.Parse (fieldText.text);
		currentValue++;
		fieldText.text = currentValue.ToString ();
	}


	public void subtractPoint()
	{
		
	}


}
