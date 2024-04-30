using UnityEngine;

public class GameQuitter : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Sadece Unity Editörde çalışırken oyunu kapatır
#else
        Application.Quit(); // Derlenmiş oyunda uygulamayı kapatır
#endif
    }
}
