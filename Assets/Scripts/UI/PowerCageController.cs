using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerCageController : MonoBehaviour {

	[SerializeField]
	private touchControl m_TouchCtrl;

	[SerializeField]
	private Slider m_Slider;

	private int m_Vaule;

	private const int m_MAX_VAULE = 10;

	private const int m_MIN_VAULE = 0;

	public bool IsCageReday( ) {
		return m_Slider.value == m_MIN_VAULE;
	}

	// Use this for initialization
	void Start () {
		m_Slider = this.GetComponent<Slider>( );
		m_TouchCtrl = GameObject.FindObjectOfType<touchControl>( );

	}
	
	// Update is called once per frame
	void Update () {
		
		m_Vaule = m_MAX_VAULE - m_TouchCtrl.enemyDownCount;

		m_Slider.value = m_Vaule;
	}
}
