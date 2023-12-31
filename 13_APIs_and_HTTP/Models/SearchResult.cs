class SearchResult<T>
{
    // From seeing the response in Postman, we know we have access to a Count property
    public int Count { get; set; }

    // There's also a next and previous, we'll skip those for now
    // The most important part is the Results property
    // Now in the JSON object, we get an array but we know we can make this a list
    // What is the type in our list though?
    // Let's make it a generic! This means declaring the Type in the class
    public List<T> Results { get; set; } = new List<T>();
}

// Once we have our model let's go build our search method