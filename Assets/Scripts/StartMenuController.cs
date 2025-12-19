using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityRoyale
{
    public class StartMenuController : MonoBehaviour
    {
        public void OnStartClick()
        {
            SceneManager.LoadScene("Main");
        }

        public void OnExitClick()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
        public void OnGuideClick()
        {
            SceneManager.LoadScene("GuideScene");
        }

    }
}
