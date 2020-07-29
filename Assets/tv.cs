using Lean.Touch;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour
{
    [SerializeField] GameObject Youtubescreen;
    
    // Start is called before the first frame update
    void Start()
    {
        Youtubescreen.GetComponent<YoutubePlayer>().Stop();
        Youtubescreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<LeanSelectable>().IsSelected)
        {
            Youtubescreen.SetActive(true);
            Youtubescreen.GetComponent<YoutubePlayer>().Play();
            gameObject.GetComponent<LeanSelectable>().IsSelected = false;
        }
    }
}
