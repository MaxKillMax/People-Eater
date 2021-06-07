using UnityEngine;

public class SpikeDeath : MonoBehaviour
{
    float Hard = StaticOptions.Difficulty / 100;
    // ѕри создании определ€ет размер шипа(и его опасность соответственно)
    private void Start()
    {
        this.transform.localScale = new Vector3(1 + Hard, 1 + Hard, 1 + Hard);
    }

    // —мертельное касание
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "SnakeHead")
        {
            other.GetComponent<OnDeath>().DestroySnake();
        }
    }
}
