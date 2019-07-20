using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldControll : MonoBehaviour {

	InputField fieldText;
	public bool autoUpdate;

	void Start()
	{
		fieldText = gameObject.GetComponent<InputField> ();
	}

	//adds 1 to the current value of the inputField
	public void addPoint()
	{
		
		int currentValue = int.Parse (fieldText.text);

		if (currentValue == null)
		{
			fieldText.text = "0";

			return;
		}

		currentValue++;
		fieldText.text = currentValue.ToString ();

	}

	//subtracts 1 from the current value of the inputField
	public void subtractPoint()
	{
		int currentValue = int.Parse (fieldText.text);

		if (currentValue == null)
		{
			fieldText.text = "0";

			return;
		}

		currentValue--;
		fieldText.text = currentValue.ToString ();
	}


	//saves to current value of textField to text file
	public void update(int currentValue)
	{
		
	}

	public void setAutoUpdate(bool autoUpdate)
	{
		
	}

}
