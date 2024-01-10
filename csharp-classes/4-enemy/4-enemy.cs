// 4-enemy.cs
using System;

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
        private int health;

        /// <summary>
        /// Represents the name of the zombie.
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// Sets the value of health to 0 and the default value of name to "(No name)".
        /// </summary>
        public Zombie()
        {
            this.health = 0;
            this.name = "(No name)";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class with a specified health value.
        /// </summary>
        /// <param name="value">The health value for the zombie.</param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            this.health = value;
            this.name = "(No name)";
        }

        /// <summary>
        /// Gets or sets the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets the health value of the zombie.
        /// </summary>
        /// <returns>The health value of the zombie.</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
