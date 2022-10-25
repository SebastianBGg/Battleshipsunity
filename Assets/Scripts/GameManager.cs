using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameState State;
    void Awake() {
        instance = this;
    }

    public void UpdateGameState(GameState newState) {
        State = newState;
        switch (newState) 
        {
            case GameState.SelectGrid:
                HandleSelectGrid();
                break;
            case GameState.Lose:
                break;
            case GameState.Player1Turn:
                break;
            case GameState.Player2Turn:
                break;
            case GameState.Victory:
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(newState), newState, null); 
        }
    }
    private void HandleSelectGrid()
    {
    }
 }
public enum GameState {
    SelectGrid,
    Player1Turn,
    Player2Turn,
    Lose,
    Victory
    }
