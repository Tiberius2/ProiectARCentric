using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public TMP_Text text;
    public void OnAnimationStart()
    {
        text.text = "Deathsphere is close. Animation Started!";
        text.gameObject.SetActive(true);
    }

    public void Init(ImageProximityDetection value)
    {
        value.animationStart += OnAnimationStart;
        value.animationEnd += OnAnimationStop;
    }

    public void OnAnimationStop()
    {
        text.text = "The objects are far apart! Idle Animation Started!";
    }
    private void Start()
    {
        text.gameObject.SetActive(false);
    }
}
