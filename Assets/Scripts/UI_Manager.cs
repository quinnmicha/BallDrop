using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    static private int totalPoints=0;
    [SerializeField]
    private TextMeshProUGUI _pointsText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _pointsText.text = "Cash: $" + totalPoints;
    }

    public void AddPoints(int points) {
        totalPoints += points;
    }


}
