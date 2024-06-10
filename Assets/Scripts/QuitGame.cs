using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class QuitGame : MonoBehaviour, IPointerClickHandler
{
    public string sceneName;

    // Tıklama olayını yöneten metod

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("qTıklandı");
        Application.Quit();
    }

    void Start()
    {
        // Mouse imlecini görünür hale getir
        Cursor.visible = true;
        // Mouse imlecinin kilidini aç
        Cursor.lockState = CursorLockMode.None;
    }
}
