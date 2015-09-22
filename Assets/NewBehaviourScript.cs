using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	
	public Transform player;
	public Text textUI;
	public Transform purp;
	public Transform orange;
	public Transform green;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		textUI.text = "";
		if ( (Vector3.Distance(new Vector3(23.7f, 0f, -34.3f), player.position) < 10f) ){
			textUI.text = "99999 the purple one knows 9999";
		}
		if ( (Vector3.Distance(purp.position, player.position) < 10f) ){
			textUI.text = "121212 yes, but i'm rather busy right now, i'm afraid 121212" + 
				"\n you might have better luck asking the green one";
		}
		if ( (Vector3.Distance(green.position, player.position) < 10f) ){
			textUI.text = "3333 da, da 3333" + "\n your apotheosis is close" + "\n and your spacebar is the key";
		}
		if ( (Vector3.Distance(orange.position, player.position) < 10f) && Input.GetKeyDown(KeyCode.Space)){
			textUI.text = "YOU WIN";
		}
	}
}
