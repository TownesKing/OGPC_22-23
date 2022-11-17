using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleStates { Start, PlayerTurn, EnemyTurn, Won, Lost }

public class CombatMain : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject enemyPrefab;
    public Transform playerBattleSation;
    public Transform enemyBattleSation;
    public BattleStates state;

    // Start is called before the first frame update
    void Start()
    {
        state = BattleStates.Start;
        SetupBattle();
    }

    void SetupBattle()
    {
        Instantiate
    }
}
