using UnityEngine;

using System.Collections;



public class raycast : MonoBehaviour

{
	public Texture oxygen;
	public Texture nitrogen;
	public Texture carbon;
	public Texture hydrogen;

	RaycastHit myhit = new RaycastHit();

    Ray myray = new Ray();

    void Update()

    {

        myray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(myray, out myhit, 1000.0f) && Input.GetMouseButtonDown(0) && Input.GetKey ("o"))
		{
			myhit.collider.renderer.material.mainTexture = oxygen;
			
		}
		
		else if (Physics.Raycast(myray, out myhit, 1000.0f) && Input.GetMouseButtonDown(0) && Input.GetKey ("n"))
		{
			myhit.collider.renderer.material.mainTexture = nitrogen;
			
		}
		else if (Physics.Raycast(myray, out myhit, 1000.0f) && Input.GetMouseButtonDown(0) && Input.GetKey ("c"))
		{	
			
			myhit.collider.renderer.material.mainTexture = carbon;
			
		}
		
		else if (Physics.Raycast(myray, out myhit, 1000.0f) && Input.GetMouseButtonDown(0) && Input.GetKey ("h"))	
		{
			
			myhit.collider.renderer.material.mainTexture = hydrogen;
			
		}
		
            

    }

}
