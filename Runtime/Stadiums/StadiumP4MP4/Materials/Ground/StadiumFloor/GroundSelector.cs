using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSelector : MonoBehaviour {
    public List<GameObject> grounds = new List<GameObject>();

    void Start() {
        float matchIndex = (float) PlayerPrefs.GetInt("MatchNumber", 0);
        int index = (int) Mathf.Floor((float) grounds.Count * matchIndex / 23f);
        // int index = Random.Range(0, (int) max);
        for (int i = 0; i < grounds.Count; i++) {
            GameObject ground = grounds[i];
            ground.SetActive(i == index);
        }
    }
}
