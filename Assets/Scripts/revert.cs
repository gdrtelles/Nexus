using UnityEngine;
using System.Collections;

public class revert : MonoBehaviour {

	 public GameObject hex_tile;
	 public Texture original;
	 int lifespan = 3;
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonUp(0) && lifespan != 0 && (Input.GetKey ("o") || Input.GetKey ("n") || Input.GetKey ("h") || Input.GetKey ("c")))
		{
            lifespan--;
		    
		}
		else if(lifespan == 0)
		{
			hex_tile.renderer.material.mainTexture = original;
			lifespan = 3;
			
		} 
		
	
	}
}
