using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public string message = "Button 1 Activated!"; // change per button in Inspector
    public string playerTag = "Player";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            UIManager.Instance.ShowMessage(message);
        }
    }
}