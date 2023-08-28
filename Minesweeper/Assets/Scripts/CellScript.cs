using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellScript : MonoBehaviour
{
    private Toggle mToggle;
    private CellState mState;

    // Start is called before the first frame update
    void Start()
    {
        mToggle = GetComponent<Toggle>();
        mToggle.isOn = false;
        mToggle.onValueChanged.AddListener(OnValueChanged);
    }

    void OnValueChanged(bool bol)
    {
        if (mState.Equals(CellState.Mine))
        {
            Debug.Log("Game Over");
        }
        else
        {
            Debug.Log("Game");
        }
        mToggle.onValueChanged.RemoveAllListeners();
        Destroy(mToggle);
        mToggle = null;
    }
}
