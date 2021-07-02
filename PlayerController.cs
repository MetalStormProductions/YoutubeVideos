using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum CharacterTypes { Commander, Engineer, Medic, Botanist, Marine };


public class PlayerController : MonoBehaviour
{
    [Tooltip("This is the type of player character that was created")]
    [SerializeField] private CharacterTypes characterType;
    [Tooltip("This is the players custom biography")]
    [TextArea] [SerializeField] private string playerBio;

    [Header("UI")]
    [Tooltip("This is a reference to the character stats panel on the user interface")]
    [SerializeField] private GameObject characterStatsPanel;
    [Tooltip("This is the sprite that will be displaye don the stats panel for the players avatar")]
    [SerializeField] private Sprite characterAvatar;
    [Space(20)]

    [Header("Locomotion")]
    [Range(0f,25f)] [SerializeField] private float runSpeed;
    [Range(0f, 5f)] [SerializeField] private float crouchSpeed;
    [Range(10f, 15f)] [SerializeField] private float moveSpeed;
    [Range(10f, 15f)] [SerializeField] private float rotateSpeed;
    [Range(10f, 15f)] [SerializeField] private float jumpSpeed;
    [Range(10f, 15f)] [SerializeField] private float jumpHeight;
    [Space(10)]

    [Header("Combat")]
    [Range(10f, 15f)] [SerializeField] private float attackRange;
    [Range(10f, 15f)] [SerializeField] private float attackSpeed;
    [Space(10)]


    [Header("Particles")]
    [SerializeField] private GameObject bloodSplatterParticles;
    [SerializeField] private GameObject healingParticles;
    [SerializeField] private GameObject moraleParticles;
    [Space(10)]

    [Header("Sounds")]
    [SerializeField] private AudioClip hitSound;
    [SerializeField] private AudioClip deathSound;
    [SerializeField] private AudioClip healSound;
    [Space(10)]

    [Header("Health")]
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth = 50;
    [Space(10)]

    [Header("Unity Events")]    
    [SerializeField] private UnityEvent onSelected = null;    
    [SerializeField] private UnityEvent onDeselected = null;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
