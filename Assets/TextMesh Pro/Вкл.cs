using UnityEngine;
using UnityEngine.UI;

public class TreeController : MonoBehaviour
{
    public GameObject treeObject; // Ссылка на объект "Дерево"
    public Button button; // Ссылка на кнопку Canvas

    private bool isTreeActive = true; // Флаг для отслеживания состояния активации

    void Start()
    {
        if (treeObject == null)
        {
            Debug.LogError("Ссылка на объект 'Дерево' не установлена. Пожалуйста, установите ссылку в инспекторе.");
        }

        if (button == null)
        {
            Debug.LogError("Ссылка на кнопку 'Кнопка' не установлена. Пожалуйста, установите ссылку в инспекторе.");
        }
        else
        {
            // Присоединяем метод ToggleTree к событию OnClick кнопки
            button.onClick.AddListener(ToggleTree);
        }
    }

    void ToggleTree()
    {
        // Если "Дерево" активно, деактивируем его, иначе активируем.
        isTreeActive = !isTreeActive;
        treeObject.SetActive(isTreeActive);
    }
}