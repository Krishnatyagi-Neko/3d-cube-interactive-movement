using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TextMeshProUGUI messageText;

    [Header("Intro Message")]
    public string introMessage = "Use WASD to move!";
    public float introDuration = 3f;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        ShowMessage(introMessage);
        Invoke(nameof(ClearMessage), introDuration);
    }

    public void ShowMessage(string msg)
    {
        CancelInvoke(nameof(ClearMessage));
        messageText.text = msg;
    }

    void ClearMessage()
    {
        messageText.text = "";
    }
}