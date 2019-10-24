using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public Player m_player;
    public SerializationCallbackScript m_SerializableScript;

    public GameData(Player p, SerializationCallbackScript s)
    {
        m_player = p;
        m_SerializableScript = s;
    }
}
