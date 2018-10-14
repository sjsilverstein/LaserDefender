using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewFormations : MonoBehaviour {

    public GameObject wave;
    private float timer;
    // Use this for initialization
	void Start () {
        GameObject newWave = Instantiate(wave, this.transform) as GameObject;
        timer = Time.time + 30;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer < Time.time) {
            Instantiate(wave, this.transform);
            timer = Time.time + 30;
        }

    }
}
