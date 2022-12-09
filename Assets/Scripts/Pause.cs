
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool _isPauseActive;

    public void ActivationPause()
    {
        if( !_isPauseActive)
        {
            _isPauseActive = true;
            Time.timeScale = 0;
        }
    }

    public void DeactivatePause()
    {
        if (_isPauseActive)
        {
            _isPauseActive = false;
            Time.timeScale = 1;
        }
    }
}
