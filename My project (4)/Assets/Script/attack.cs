Animator anim;

void Start()
{
    anim = GetComponent<Animator>();
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        anim.SetTrigger("Attack");
    }
}