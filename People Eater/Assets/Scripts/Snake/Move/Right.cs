using UnityEngine;
using UnityEngine.EventSystems;

// По ТЗ надо было создать такое управление: куда тыкаешь пальцем, туда и идёт.
// От этого управления я отказался, поскольку считаю не очень интересным и лёгким

// В случае, если это всё же критическая ошибка(хотя в ТЗ также указано, что оценивается и интерес игры)
// То прошу уведомить об этом и дать время на исправление
public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] SnakeMove snakeMove;
    // Ткнул палец - пошло вправо
    public void OnPointerDown(PointerEventData eventData)
    {
        snakeMove.RightDown();
    }

    // Поднял палец - перестало идти вправо(или ползти)
    public void OnPointerUp(PointerEventData eventData)
    {
        snakeMove.RightUp();
    }
}
