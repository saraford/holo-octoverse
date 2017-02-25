using UnityEngine;
using UnityEngine.VR.WSA.Input;

// https://developer.microsoft.com/en-us/windows/holographic/holograms_101#chapter_3_-_gestures
public class ManageNodeOnSelect : MonoBehaviour
{
    private Color originalColor;
    public GameObject nodeTitle;
    private bool showingTitle = true;
    void Start()
    {
        originalColor = this.GetComponent<Renderer>().material.color;
    }

    void HideTitle()
    {
        showingTitle = false;
    }

    void ShowTitle()
    {
        showingTitle = true;
    }

    private void OnSelect()
    {
        var node = this.GetComponent<Renderer>();
        node.material.color = Color.yellow;

        if (showingTitle)
        {
            nodeTitle.SetActive(true);
        }

    }

    private void OnReset()
    {
        var node = this.GetComponent<Renderer>();
        node.material.color = originalColor;

        nodeTitle.SetActive(false);
    }


}