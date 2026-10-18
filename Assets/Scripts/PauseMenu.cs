
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public GameObject panelPausa;

    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.escapeKey.wasPressedThisFrame ||
            Keyboard.current.pKey.wasPressedThisFrame)
        {
            if (Time.timeScale == 1f)
            {
                panelPausa.SetActive(true);
                Time.timeScale = 0f;
            }
            else
            {
                panelPausa.SetActive(false);
                Time.timeScale = 1f;
            }
        }
    }

    public void Reanudar()
    {
        panelPausa.SetActive(false);
        Time.timeScale = 1f;
    }
}
