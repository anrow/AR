using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoFade : MonoBehaviour {

    [SerializeField]
    private Image m_Image;

    [SerializeField]
    private const float speed = 0.01f;

    private float alfa;

    private void Awake( ) {
       
    }
    private void Start( ) {
        if( m_Image == null ) {
            m_Image = this.GetComponent<Image>( );
        }
        alfa = m_Image.color.a;
    }
    private void Update( ) {
        m_Image.color = new Color( 255, 255, 255, alfa );
        alfa += speed;
    }
}
