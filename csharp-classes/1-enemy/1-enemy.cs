using System;

// 1-enemy.cs
namespace Enemies
{
    /// <summary>
    /// Represents a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Represents the health of the zombie.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// Sets the value of health to 0.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
    }
}
