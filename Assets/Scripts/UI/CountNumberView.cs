using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountNumberView : MonoBehaviour {

    [SerializeField]
    private Image m_TensPlaceImg;

    [SerializeField]
    private Image m_OnesPlaceImg;

    [SerializeField]
    private Sprite[ ] m_Sprites;

    private int m_Number;

    public int Number {
        get { return m_Number; }
        set { m_Number = value; }
    }

	// Use this for initialization
	void Start( ) {
	
	}
	
	// Update is called once per frame
	void Update( ) {

        int m_TensPalceNum = m_Number / 10 % 10;

        int m_OnesPlaceNum = m_Number % 10;

        m_TensPlaceImg.sprite = m_Sprites[ m_TensPalceNum ];
        m_OnesPlaceImg.sprite = m_Sprites[ m_OnesPlaceNum ];
	}
}
