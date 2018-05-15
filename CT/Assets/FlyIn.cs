using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyIn : MonoBehaviour {
    public float Speed;
    public bool lerpstop;
    public GameObject Continue;
    public float WaitTime;
    public AudioSource Slam;
    public bool CanContinue;
    public GameObject Main;
    public GameObject Selection;
    public AudioSource Con;
	// Use this for initialization
	void Start () {
        StartCoroutine(Stop());
	}
	IEnumerator Stop()
    {
        yield return new WaitForSeconds(.4f);
        Slam.Play();
        yield return new WaitForSeconds(WaitTime);
        lerpstop = true;
        Continue.SetActive(true);
        CanContinue = true;
        
    }
	// Update is called once per frame
	void Update () {
        if (CanContinue)
        {
            if (Input.anyKeyDown)
            {
                Con.Play();
                Main.SetActive(false);
                Selection.SetActive(true);
                CanContinue = false;
                
            }
        }
        if (!lerpstop)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0.7f, 0.7f, 0.7f), Speed);
        }
	}
}
