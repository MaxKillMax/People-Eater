using UnityEngine;
using UnityEngine.EventSystems;

// �� �� ���� ���� ������� ����� ����������: ���� ������� �������, ���� � ���.
// �� ����� ���������� � ���������, ��������� ������ �� ����� ���������� � �����

// � ������, ���� ��� �� �� ����������� ������(���� � �� ����� �������, ��� ����������� � ������� ����)
// �� ����� ��������� �� ���� � ���� ����� �� �����������
public class Right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] SnakeMove snakeMove;
    // ����� ����� - ����� ������
    public void OnPointerDown(PointerEventData eventData)
    {
        snakeMove.RightDown();
    }

    // ������ ����� - ��������� ���� ������(��� ������)
    public void OnPointerUp(PointerEventData eventData)
    {
        snakeMove.RightUp();
    }
}
