using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
    int pos = 0;
    public GameObject start;
    public GameObject exit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(pos==0)
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, -0.2f);
        }
        else
        {
            gameObject.transform.position = new Vector2(gameObject.transform.position.x, exit.transform.position.y*1.6f );
        }

        if(Input.GetKeyDown(KeyCode.UpArrow)|| Input.GetKeyDown(KeyCode.DownArrow))
        {
            pos = 1 - pos;
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            switch(pos)
            {
                case 0: SceneManager.LoadScene("mario");
                        return;
                case 1:
                        Application.Quit();
                        return;

            }
        }
		
	}
}
