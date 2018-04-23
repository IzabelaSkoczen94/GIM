using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyramid : MonoBehaviour {

	public int height = 5;
    public float offsetX = 1;
	public float offsetY = 2.05f;
    public GameObject obj;


    // Use this for initialization
	void Start () {
		int baseSize = height * 2 - 1;



		for (int k = 0; k < height; k++)
		{
			for (int i = k; i < baseSize - k; i++)
        	{
				for (int j = k; j < baseSize - k; j++)
            	{
                	GameObject temp_obj = Instantiate(obj, transform, false);
					temp_obj.transform.Translate(new Vector3(i * offsetX, k * offsetY, j * offsetX));
            	}
        	}
		}
	}
}
