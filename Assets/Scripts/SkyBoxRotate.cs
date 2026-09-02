using UnityEngine;

public class SkyBoxRotate : MonoBehaviour
{
    private float rotation;

    void Update()
    {
        rotation += Time.deltaTime * 1.2f;
        RenderSettings.skybox.SetFloat("_Rotation", rotation);
    }
}