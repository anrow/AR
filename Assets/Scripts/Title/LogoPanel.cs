using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoPanel : MonoBehaviour {

    [SerializeField]
    private Image m_Image;

    [SerializeField]
    private const float speed = 0.01f;

    private float m_alfa;

    private void Start( ) {
        if( m_Image == null ) {
            m_Image = this.gameObject.GetComponentInChildren<Image>( );
        }
        m_alfa = 0;
    }
    private void Update( ) {

        m_Image.color = new Color( 255, 255, 255, m_alfa );
       
        m_alfa += speed;
    }
}
