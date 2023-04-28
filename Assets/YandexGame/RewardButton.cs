using UnityEngine;
using YG;


public class RewardButton : MonoBehaviour
{
    [SerializeField] private DisplayCoins _coins;
    
    // ������������� �� ������� �������� ������� � OnEnable
    private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

    // ������������ �� ������� �������� ������� � OnDisable
    private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;


    void Rewarded(int id)
    {
        _coins.AddWatched();
    }

    // ����� ��� ������ ����� �������
    public void MoreGoldAdReward(int id)
    {
        YandexGame.RewVideoShow(id);
    }
}

