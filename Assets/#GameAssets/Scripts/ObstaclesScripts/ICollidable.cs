using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollidable
{
    public void OnCollided(PlayerMovements playerMovements);
}
