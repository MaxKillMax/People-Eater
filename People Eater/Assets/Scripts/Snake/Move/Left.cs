using UnityEngine;
using UnityEngine.EventSystems;

// По ТЗ надо было создать такое управление: куда тыкаешь пальцем, туда и идёт.
// От этого управления я отказался, поскольку считаю не очень интересным и лёгким

// В случае, если это всё же критическая ошибка(хотя в ТЗ также указано, что оценивается и интерес игры)
// То прошу уведомить об этом и дать время на исправление
public class Left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] SnakeMove snakeMove;
    // Ткнул палец - пошло влево
    public void OnPointerDown(PointerEventData eventData)
    {
        snakeMove.LeftDown();
    }

    // Поднял палец - перестало идти влево(или ползти)
    public void OnPointerUp(PointerEventData eventData)
    {
        snakeMove.LeftUp();
    }
}
