using UnityEngine;
using UnityEngine.UI;

// Данный скрипт связывается с StaticOptions с меню настроек
public class Options : MonoBehaviour
{
    [SerializeField] Slider Difficulty;
    [SerializeField] Slider ChunkCount;
    [SerializeField] Toggle Immortality;

    private void Start()
    {
        Difficulty.value = StaticOptions.Difficulty;
        ChunkCount.value = StaticOptions.ChunkCount;
        Immortality.isOn = StaticOptions.Immortality;
    }

    public void SetDifficulty()
    {
        StaticOptions.GetDifficulty(Mathf.RoundToInt(Difficulty.value));
    }

    public void SetChunkCount()
    {
        StaticOptions.GetChunkCount(Mathf.RoundToInt(ChunkCount.value));
    }

    public void SetImmortality()
    {
        StaticOptions.GetImmortality(Immortality.isOn);
    }
}
