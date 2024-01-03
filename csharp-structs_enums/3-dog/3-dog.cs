using System;

// Define the Rating enum
enum Rating
{
    Good,
    Great,
    Excellent
}

// Define the Dog struct with a constructor and overridden ToString() method
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    // Constructor with parameters
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    // Override ToString() to print object attributes
    public override string ToString()
    {
        return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
    }
}