using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityRoyale
{
    public class GoBackToMenu : MonoBehaviour
    {
        public void OnClickToMenu()
        {
            SceneManager.LoadScene("StartMenu");
        }
    }
}
