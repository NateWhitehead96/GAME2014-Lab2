using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    //public TMP_Text Scenelabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                //Scenelabel.text = "Portrait";
                LivesLabel.rectTransform.anchoredPosition = new Vector3(248f, -200f, 0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector3(-353f, -200f, 0f);
                break;
            case DeviceOrientation.LandscapeLeft:
                //Scenelabel.text = "LandscapeLeft";
                LivesLabel.rectTransform.anchoredPosition = new Vector3(370f, -83f, 0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector3(-353f, -83f, 0f);
                break;
            case DeviceOrientation.LandscapeRight:
                //Scenelabel.text = "LandscapeRight";
                LivesLabel.rectTransform.anchoredPosition = new Vector3(248f, -83f, 0f);
                ScoreLabel.rectTransform.anchoredPosition = new Vector3(-500f, -83f, 0f);
                break;
            case DeviceOrientation.Unknown:
                //Scenelabel.text = "Unknown";
                break;
        }
    }
}
