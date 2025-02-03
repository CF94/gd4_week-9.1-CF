using TMPro;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    public TMP_Text text;

    public void UpdateText()
    {
        text.text = "Hello World";
    }
}
