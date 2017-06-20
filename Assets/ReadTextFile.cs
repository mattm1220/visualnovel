using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadTextFile : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		ReadText ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void ReadText ()
	{
		// The path of the file to be read
		string path = "Assets/test";

		// The reader object
		StreamReader reader = new StreamReader (path);

		// Read the contents of the file
		string buffer = "";
		while (!reader.EndOfStream) 
		{
			int i = reader.Read ();
			char c = System.Convert.ToChar (i);
			if (c == '=') 
			{
				switch (buffer) 
				{
				case ("fadeout"): 
					break;
				case ("fadein"): 
					break;
				case ("location"): 
					break;
				case ("character1"):
					SetCharacter1 (reader);
					buffer = "";
					break;
				case ("character2"):
					SetCharacter2 (reader);
					buffer = "";
					break;
				case ("emotion1"): 
					break;
				case ("emotion2"): 
					break;
				case ("speaking"):
					break;
				case ("speed"): 
					break;
				case ("line"): 
					break;
				default: 
					break;
				}
			} 
			else 
			{
				buffer += c;
			}

		}

		// Close the file
		reader.Close ();
	}

	void SetLocation(StreamReader reader)
	{
		// If using 2D backgrounds, set the image to be displayed
		// If using 3D backgrounds, set the camera's location
	}
	
	void SetCharacter1(StreamReader reader)
	{
		// Load a set of sprites into the character 1 slot
		Debug.Log (reader.ReadLine());
	}

	void SetCharacter2(StreamReader reader)
	{
		// Load a set of sprites into the character 2 slot
		Debug.Log (reader.ReadLine());
	}

	void SetCharacterEmotion1(StreamReader reader)
	{
		// Load a specific set of images into the current active animation for character 1
		Debug.Log (reader.ReadLine());
	}

	void SetCharacterEmotion2(StreamReader reader)
	{
		// Load a specific set of images into the current active animation for character 2
		Debug.Log (reader.ReadLine());
	}

	void SetSpeaking(StreamReader reader)
	{
		// Check to see if the speaking character is character 1, character 2, or self
		// Set the active speaker's name to appear in the dialogue box
		// If the speaker is equal to either of the characters,
		// play the speaking animation corresponding to that character's emotion
		// Otherwise, play the idle animation corresponding to that character's emotion
		Debug.Log (reader.ReadLine());
	}

	void SetTextSpeed(StreamReader reader)
	{
		// Set the speed at which characters appear in the dialogue box
		// NOTE: If fastforward = true, the speed will be overridden and set to max
	}

	void SetTextLine(StreamReader reader)
	{
		// Set the line of dialogue to be displayed
		// Loop through reading the lines
		// Check for a special character that denotes the end of the lines
		// Also, check for input from the player for the dialogue to be advanced
		// Don't read the next line until the dialogue has been advanced
		// NOTE: If fastforward = true, the dialogue will be advanced as soon as the line is displayed in full
	}
}
