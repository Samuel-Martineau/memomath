using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperlinkScript : MonoBehaviour {

    public void OpenHyperlink (string WebsiteUrl)
    {
        Application.OpenURL("http://Memomath.org");
    }
}
