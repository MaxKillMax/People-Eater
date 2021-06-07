using UnityEngine;

public class PlatformSpeed : MonoBehaviour
{
    private SpawnController spawnController;
    private float Move;
    private float Speed;
    // Получение информации платформе при создании этого
    public void GetInformation(SpawnController Controller, GameObject Snake, float Speed)
    {
        this.Speed = Speed;
        Move = Snake.GetComponentInChildren<SnakeMove>().Speed;
        spawnController = Controller;
    }

    // Меняет скорость (работает так, что последующий чанк меняет скорость на этом чанке.
    // происходит так, потому что лень менять, так как нет смысла: в этом система не нуждается)
    public void ChangeSpeed()
    {
        Move = Speed;
        print("Установлена скорость: " + Speed);
    }

    // Переходник для PlatformCollider.cs (он уже как рудимент, его надо бы удалить и сделать напрямую из него)
    public void Next()
    {
        spawnController.CreateNewChunk();
    }
}
