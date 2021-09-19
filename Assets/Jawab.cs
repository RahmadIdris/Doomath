using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jawab : MonoBehaviour{
	public GameObject feed_Benar, feed_Salah;

    // Start is called before the first frame update
    void Start() {
    }
    
    
    public void jawaban(bool jawab){
		if (jawab) {
			feed_Benar.SetActive (false);
			feed_Benar.SetActive (true);
			int skor = PlayerPrefs.GetInt ("skor")+10;
			PlayerPrefs.SetInt ("skor", skor);
		} else {
			feed_Salah.SetActive (false);
			feed_Salah.SetActive (true);
		}
		gameObject.SetActive (false);
		transform.parent.GetChild(gameObject.transform.GetSiblingIndex()+1).gameObject.SetActive (true);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
