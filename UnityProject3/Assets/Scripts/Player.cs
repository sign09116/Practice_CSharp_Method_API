using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    #region 屬性
    /// <summary>
    /// 玩家移動速度
    /// </summary>
    [Header("移動速度"), Range(30, 100)]
    public float Speed;
    /// <summary>
    /// 玩家身上的剛體
    /// </summary>
    [Header("玩家剛體")]
    public Rigidbody2D PlayerRig;
    /// <summary>
    /// 玩家的圖片渲染器
    /// </summary>
    [Header("玩家Sprite randerer")]
    public SpriteRenderer playerSR;

    #endregion

    #region 事件
    private void Awake()
    {
        PlayerRig = GetComponent<Rigidbody2D>();
        playerSR = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        Move();
    }


    #endregion

    #region 方法

    void Move()
    {
        float _Speed = Input.GetAxisRaw("Horizontal") * Speed * Time.deltaTime;
        if (_Speed < 0)
        {
            playerSR.flipX = true;
            PlayerRig.AddForce(Vector2.right * _Speed, ForceMode2D.Impulse);

        }
        else
        {
            playerSR.flipX = false;
            PlayerRig.AddForce(Vector2.right * _Speed, ForceMode2D.Impulse);
        }

    }


    #endregion

}
