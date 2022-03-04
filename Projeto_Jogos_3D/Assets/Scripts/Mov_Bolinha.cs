using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Bolinha : MonoBehaviour
{
    public float movX;
    public float movZ;
    public float velocidade;
    [SerializeField]
    private float forcaPulo;

    public KeyCode paraFrente;
    public KeyCode paraTraz;
    public KeyCode paraDireita;
    public KeyCode paraEsquerda;

    Rigidbody fisica;

    bool podePular = false;

    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        #region 1ª forma de pegar o valor do jogador
        //movX = Input.GetAxis("Horizontal");
        //movZ = Input.GetAxis("Vertical");
        #endregion

        #region 2ª forma de pegar o valor do jogador
        if (Input.GetKey(paraFrente))
        {
            movZ = 1;
        }
        if (Input.GetKey(paraTraz))
        {
            movZ = -1;
        }
        if (Input.GetKey(paraEsquerda))
        {
            movX = -1;
        }
        if (Input.GetKey(paraDireita))
        {
            movX = 1;
        }
        #endregion

        Vector3 move = new Vector3(movX * Time.deltaTime, 0, movZ * Time.deltaTime);


        #region 1ª forma de movimento
        transform.Translate(move * velocidade); 
        #endregion

        #region 2ª forma de movimento
        //fisica.AddForce(move * velocidade);
        #endregion

        #region 3ª forma de movimento
        //fisica.velocity = move * velocidade;
        #endregion

        //pulo da bolinha
        if (Input.GetKeyDown(KeyCode.Space) && podePular)
        {
            fisica.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            podePular = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Ground")
        {
            podePular = false;
        }
    }
}