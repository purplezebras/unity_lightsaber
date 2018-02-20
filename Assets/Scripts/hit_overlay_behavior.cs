using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_overlay_behavior : MonoBehaviour {

    private IEnumerator coroutine;
	// Use this for initialization
	void Start () {
        coroutine = FadeCoroutine();
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void FadeAnimation()
    {
        StartCoroutine(coroutine);
        coroutine = FadeCoroutine();
    }

    //Fades the screen in to red and then to clear again.
    public IEnumerator FadeCoroutine()
    {
        Color oldColor = GetComponent<Renderer>().material.color;
        for (float a = 0.0f; a < .5f; a += Time.deltaTime)
        {
            GetComponent<Renderer>().material.color = new Color(oldColor.r, oldColor.g, oldColor.b, a);
            yield return null;
        }
        for (float a = .5f; a >= 0f; a -= Time.deltaTime)
        {
            GetComponent<Renderer>().material.color = new Color(oldColor.r, oldColor.g, oldColor.b, a);
            yield return null;
        }

    }
}
